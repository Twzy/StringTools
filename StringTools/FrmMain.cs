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

namespace StringTools
{
    public partial class FrmMain : Form
    {

        /// <summary>
        /// 脚本实现接口
        /// </summary>
        ICommand cmdEntity;


        public FrmMain()
        {
            InitializeComponent();

            //RichTextBox 输入字体一致性设置（）
            txtInput.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            txtOutput.LanguageOption = RichTextBoxLanguageOptions.UIFonts;


            if (IniteScrpit())//初始化脚本
            {
                IniteConsole();//初始化命令行控件
                IniteAutoCompete();//初始化自动补全控件
            }
       
        }


        #region 初始化

        #region 脚本初始化


        /// <summary>
        /// 初始化脚本
        /// </summary>
        /// <returns></returns>
        private bool IniteScrpit()
        {

    
            try
            {

                //脚本初始化方式  注意 脚本必须实现ICommand 接口
                AsmHelper asm = new AsmHelper(CSScript.Load(Config.ScriptPath,null,true));
                cmdEntity = (ICommand)asm.CreateObject("*");

                cmdEntity.CurrMainForm = this;
                ((BaseCommand)cmdEntity).IniteBtn();
                cmdEntity.DefaultColor = txtCon.ForeColor;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show( "脚本加载错误:\r\n"+ex.Message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);
                return false;
            }


        }

        #endregion

        #region  命令行控件初始化

        /// <summary>
        /// 命令行控件初始化
        /// </summary>
        private void IniteConsole()
        {

            txtCon.HeadText = "-->: ";//命令行每行的前缀
            txtCon.ReadCommandtEvent += txtCon_ReadCommandtEvent;//当每条命令被输入（按下回车键后）调用的事件方法
            txtCon.Write(Config.headStr);//写入命令行头部信息，并进入接受命令的状态
        }

        void txtCon_ReadCommandtEvent(object sender, ConsoleUI.ConsoleEditEventArgs e)
        {
            //通过加载脚本获取的实体 执行输入的命令
            cmdEntity.Exec(e.Message, txtInput.Text);

        }
        #endregion

        #region 自动提示初始化

        private void IniteAutoCompete()
        {
            //读取脚本实体中设定的命令，组成提示列表
            var items = new List<AutocompleteItem>();
            foreach (var item in cmdEntity.CommandList)
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






    }
}
