using AutocompleteMenuNS;
using CSScriptLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StringTools
{
    public partial class FrmMain : Form
    {




        public FrmMain()
        {
            InitializeComponent();

            FormClosing += FrmMain_FormClosing;

            //RichTextBox 输入字体一致性设置（）
            txtInput.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            txtOutput.LanguageOption = RichTextBoxLanguageOptions.UIFonts;

            Common.LoadCodeMode();

            if (IniteScrpit())//初始化脚本
            {
                IniteConsole();//初始化命令行控件
                IniteAutoCompete();//初始化自动补全控件
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Common.Log();
        }


        #region 初始化

        #region 脚本初始化

        /// <summary>
        /// 程序集脚本
        /// </summary>
        AsmHelper AsmHelper;
        /// <summary>
        /// 脚本对象
        /// </summary>
        object ExecScript;

        /// <summary>
        /// 命令列表
        /// </summary>
        Dictionary<string, string> CommandList;


        /// <summary>
        /// 对输入参数不转义列表
        /// </summary>
        string[] UnEscapeArry = new string[0];
        /// <summary>
        /// 初始化脚本
        /// </summary>
        /// <returns></returns>
        public bool IniteScrpit()
        {
            try
            {

                //脚本初始化方式  注意 脚本必须实现ICommand 接口
                AsmHelper = new AsmHelper(CSScript.Load(Config.ScriptPath, null, true));
                ExecScript = AsmHelper.CreateObject("*");
                ((BaseCommand)ExecScript).CurrMainForm = this;
                ((BaseCommand)ExecScript).logHandler = OnCmdLogArrivl;

                AsmHelper.InvokeInst(ExecScript, "*.Inite");//初始化
                UnEscapeArry = (string[])AsmHelper.InvokeInst(ExecScript, "*.UnEscape");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("脚本加载错误:\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new FrmCode().ShowDialog();
                Application.Exit();
                return false;
            }
        }

        #endregion

        #region  命令行控件初始化

        string regExp = @"^\s*(\w+|\?)(\s|$)";

        /// <summary>
        /// 命令行控件初始化
        /// </summary>
        private void IniteConsole()
        {

            txtCon.HeadText = "-->: ";//命令行每行的前缀
            txtCon.ReadCommandtEvent += TxtCon_ReadCommandtEvent;//当每条命令被输入（按下回车键后）调用的事件方法
            txtCon.Write(string.Format(@"{0}

代码版本：V{1}
命令数量：{2}
",
Config.headStr, Common.Code.VerDateTime,
Common.Code.CommandList.Count().ToString()));//写入命令行头部信息，并进入接受命令的状态
        }

        #endregion

        #region 自动提示初始化

        public void IniteAutoCompete()
        {
            //读取脚本实体中设定的命令，组成提示列表
            var items = new List<AutocompleteItem>();
            CommandList = (Dictionary<string, string>)AsmHelper.InvokeInst(ExecScript, "*.GetCommandList");
            foreach (var item in CommandList)
                items.Add(new SnippetAutocompleteItem(item.Key + " ^") { ToolTipText = item.Value, ToolTipTitle = item.Key, ImageIndex = 1 });

            //设置自动提示
            autocompleteMenu1.SetAutocompleteItems(items);
        }

        //因为命令行控件具有记忆功能，按上下方向键可以翻阅以前输入的条目，而当自动提示菜单打开状态，按上下方向键应该只具备选中菜单的功能
        //因此加该标志作为是否启用记忆功能的开关
        private void autocompleteMenu1_Opening(object sender, CancelEventArgs e)
        {
            txtCon.IsAcceptInput = false;
        }

        private void autocompleteMenu1_Closing(object sender, EventArgs e)
        {
            txtCon.IsAcceptInput = true;
            toolTip1.Hide(autocompleteMenu1.Host);
        }


        //当选中对应的命令时应该给出对应的提示说明信息
        private void autocompleteMenu1_SelectChange(object sender, SelectingEventArgs e)
        {
            if (e.SelectedIndex == -1)
                return;

            toolTip1.ToolTipTitle = e.Item.ToolTipTitle;
            toolTip1.Show(e.Item.ToolTipText, autocompleteMenu1.Host, autocompleteMenu1.MaximumSize.Width + 10, 0);
        }


        #endregion
        #endregion


        Model.RunModel CurrRun;
        void TxtCon_ReadCommandtEvent(object sender, ConsoleUI.ConsoleEditEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Message.Trim()))
            {
                txtCon.Write();
                return;
            }

            CurrRun = new Model.RunModel();
            CurrRun.CommandLine = e.Message;

            //通过加载脚本获取的实体 执行输入的命令
            string cmd = "";
            try
            {
                var m = Regex.Match(e.Message, regExp, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                if (m.Success)
                {
                    cmd = m.Groups[0].Value.Trim().ToLower();

                    //记录器
                    CurrRun.CmdName = cmd;
                    CurrRun.Cmd = Common.GetCommandByName(cmd);

                    //参数执行调度
                    var paramList = e.Message.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (paramList.Count() > 1)
                    {
                        paramList = paramList.Skip(1).ToArray();
                        if (!UnEscapeArry.Contains(cmd))//不在非转义数组之内
                        {
                            paramList = Tools.RepEscape(paramList);//转义
                        }
                    }
                    else
                    {
                        paramList = new string[0];
                    }

                    if (cmd == "?") cmd = "help";

                    AsmHelper.InvokeInst(ExecScript, "*." + cmd, e.Message, paramList);


                }
                else
                {
                    ((BaseCommand)ExecScript).Cmd("未知的命令:" + e.Message);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                if (CommandList.Keys.Contains(cmd))
                {
                    ((BaseCommand)ExecScript).Cmd("参数错误，请按下列说明配置数据：\r\n" + cmd + ":\r\n" + CommandList[cmd]);
                }
                else
                {
                    ((BaseCommand)ExecScript).Cmd("未知的命令:" + e.Message);
                }
            }
            catch (ApplicationException ex)
            {
                ((BaseCommand)ExecScript).Cmd("未知的命令:" + e.Message);
            }
            catch (Exception ex)
            {
                ((BaseCommand)ExecScript).Cmd("未知的命令:" + e.Message + "\r\n错误：" + ex.Message);
            }
            finally
            {
                Common.Document.RecoderList.Add(CurrRun);
                txtCon.Write();
            }
        }
        /// <summary>
        /// 当输入数据到来的时候
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        public void OnCmdLogArrivl(IOType t, string msg)
        {
            CurrRun.CmdLogList.Add(new Model.IOList { Type = t, Content = msg });
        }

        /// <summary>
        /// 定位焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            txtCon.Focus();
        }
    }
}
