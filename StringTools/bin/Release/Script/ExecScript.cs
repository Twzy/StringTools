//css_import StringExtension.cs

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace StringTools
{
    public class ExecScript : BaseCommand, ICommand
    {
        public ExecScript()
        {
            BuildList();
        }
		
		Random rand=new Random (DateTime.Now.Millisecond);

		//生成命令列表，用于自动提示
        private void BuildList()
        {
            CommandList = new Dictionary<string, string>();
            CommandList.Add("rep", "rep [1] [2]\r\n   -- 字符串替换,[1] 目标，[2] 替换内容");
            CommandList.Add("repregx", "repregx [1] [2]\r\n   -- 字符串替换,[1] 正则表达式 ,[2] 替换内容");
            CommandList.Add("idx", "idx [1]\r\n   -- 顺序查找字符位置,[1] 字符");
            CommandList.Add("ldx", "ldx [1]\r\n   -- 逆序查找字符位置,[1] 字符");
            CommandList.Add("len", "len\r\n   -- 字符串长度");
            CommandList.Add("spl", "spl [1]\r\n   -- 字符串按指定字符分为行,[1]字符 ");
            CommandList.Add("spe", "spe [1] [2] [3] [4]\r\n   -- 字符串替换扩展,[1] 目标，[2] 左侧 [3] 右侧 [4] 替换内容");
            CommandList.Add("sbr", "sbr\r\n   -- 字符串封装StringBuilder");
            CommandList.Add("regex", "regex [1]\r\n   -- 正则表达式匹配");
            CommandList.Add("popo", "popo\r\n   -- 这都是泡沫");			
            CommandList.Add("setbuff", "setstr\r\n   -- 设置模板数据");
			CommandList.Add("showbuff", "showstr\r\n   -- 显示模板数据");
			CommandList.Add("putstr", "putstr\r\n   -- 生成数据");	
			CommandList.Add("for","for [1] [2] [3]\r\n  -- 循环加索引 [1] 起始值 [2] 最大值 [3] 步长");

			
            CommandList.Add("print", "print [1]\r\n   -- 向输出打印数据");
			CommandList.Add("up", "up\r\n   -- 将输出结果作为输入");
            CommandList.Add("cls", "cls\r\n   -- 清理命令区域内容");
            CommandList.Add("?", "?\r\n   -- 帮助 同 “help”");
            CommandList.Add("help", "help\r\n   -- 帮助 同 “?”");
            CommandList.Add("cmdlst", "cmdlst\r\n   -- 列出当前可用的命令");
            CommandList.Add("ver", "ver\r\n   -- 获取脚本版本");
        }


		//命令执行入口
        public void Exec(string cmd, string inptuText)
        {
            if (string.IsNullOrEmpty(cmd))
            {
                WriteCommand();
                return;
            }

            string[] arr = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (arr[0] != "regex")
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[0] == "repregx" && i == 1)
                        continue;
                    arr[i] = arr[i].Replace("\\s", " ").Replace("\\t", "\t")
                                   .Replace("\\d", "").Replace("\\n", "\n")
                                   .Replace("\\r", "\r");
                }
            }

            try
            {
                switch (arr[0])
                {
                    case "rep":
                        Print(inptuText.Replace(arr[1], arr[2]));
                        break;
                    case "idx":
                        Print(inptuText.IndexOf(arr[1]).ToString());
                        break;
                    case "ldx":
                        Print(inptuText.LastIndexOf(arr[1]).ToString());
                        break;
                    case "len":
                        Print(inptuText.Length.ToString());
                        break;
                    case "spl":
                        Print(inptuText.SplitForRow(new char[] { arr[1][0] }));
                        break;
                    case "spe":
                        Print(inptuText.SplitWithOp(arr[1].ToCharArray(), arr[2], arr[3], arr[4]));
                        break;
                    case "sbr":
                        Print(inptuText.ToStringBuilder());
                        break;
				    case "popo":
					    StringBuilder popSbr=new StringBuilder();
                        for (int pop1 = 0; pop1 < 1000; pop1++)
                        {
							var popoRand=rand.Next(0,9);
							switch (popoRand-1)
							{
								case 0:popSbr.Append(".");break;
								case 1:popSbr.Append("。");break;
								case 2:popSbr.Append("o");break;
								case 3:popSbr.Append("O");break;
								case 4:popSbr.Append("0");break;
								case 5:popSbr.Append("゜");break;
								case 6:popSbr.Append("○");break;
								case 7:popSbr.Append("Ｏ");break;
								case 8:popSbr.Append("〇");break;
							}
                            if (pop1 % 50 == 49)
                            {
                                popSbr.AppendLine();
                            }

                        }
                        Print(popSbr.ToString());
					    break;
                    case "regex":
                        var ms = Regex.Matches(inptuText, arr[1]);
                        StringBuilder regxsbr = new StringBuilder();
                        foreach (Match i in ms)
                        {
                            regxsbr.AppendLine("---------------------------");
                            regxsbr.AppendFormat("{0}\r\n", i.Value);
                            foreach (Group j in i.Groups)
                            {
                                regxsbr.AppendFormat("    {0}\r\n", j.Value);
                            }
                        }

                        Print(regxsbr.ToString());
                        break;
                    case "repregx":
                        Print(Regex.Replace(inptuText, arr[1], arr[2]));
                        break;
					case "setbuff":
					   //modelStr=cmd.TrimStart(new char[]{' '});
					   modelStr=inptuText;//modelStr.Substring(6);
					   LabStatus.Text="缓冲区:"+modelStr;
					   WriteCommand("");
                       break;
					case "showbuff": 
					   Print(modelStr);
					   break;
					case "for":
					    Print(ForModelStr(arr[1],arr[2],arr[3]));
					   break;
					case "putstr":
					   Print(GetModelStr(inptuText,arr));
					   break;
					case "up":
					   CurrMainForm.txtInput.Text = CurrMainForm.txtOutput.Text;
					   Print("");
                       break;					
                    case "cmdlst":
                        StringBuilder cmdListStr = new StringBuilder();
                        var cmdList=CommandList.Keys.ToArray();
                        for (int i = 0; i <cmdList.Length; i++)
                        {
                            cmdListStr.Append(cmdList[i].PadRight(10, ' '));
                            if (i%6 == 5)
                            {
                                cmdListStr.AppendLine();
                            }
                        }
                        WriteCommand(cmdListStr.ToString());
                        break;
                    case "print":
                        Print(arr[1]);
                        break;
                    case "cls":
                        ClearCommand();
                        break;
                    case "?":
                    case "help":
                        if (arr.Length == 2 && CommandList.Keys.Contains(arr[1]))
                        {
                            WriteCommand(CommandList[arr[1]]);
                        }
                        else
                        {
                            WriteCommand(HelpDoc());
                        }
                        break;
                    case "ver":
                        WriteCommand(VersionName());
                        break;
                    default:
                        WriteCommand("未知的命令！", Color.DarkGreen);
                        break;
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                WriteCommand("参数错误！Eg:\r\n" + CommandList[arr[0]], Color.Tomato);
            }
            catch (Exception ex1)
            {
                WriteCommand("错误：" + ex1.Message, Color.Tomato);
            }
        }

		private string modelStr="";
		public string GetModelStr(string msg,string[] indexArry)
		{
            List<string> plist = new List<string>();
            string[] strArry = msg.Split(new char[]{'\n'},StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sbr = new StringBuilder();
           
            foreach (var i in strArry)
            {
				plist.Clear();
                string[] itemArry = i.Split('\t');
                for (int j = 1; j < indexArry.Length; j++)
                {
                    plist.Add(itemArry[int.Parse(indexArry[j])]);
                }

                sbr.AppendFormat(modelStr,plist.ToArray());
                sbr.AppendLine();
            }
			return sbr.ToString();
		}
		
		private string ForModelStr(string start,string max,string step)
		{
			int i=int.Parse(start);
			int l=int.Parse(max);
			int s=int.Parse(step);
			
			StringBuilder sbr = new StringBuilder();
           
            for ( ; i <= l; i+=s)
            {
               sbr.AppendFormat(modelStr,i);
			   sbr.AppendLine();
            }
            
			return sbr.ToString();
			
		}
	
		
		//获取帮助文档
        public string HelpDoc()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendLine("帮助功能");
            sbr.AppendLine("------------------------------------");
            sbr.AppendLine("[命令]");
            foreach (var i in CommandList)
            {
                sbr.AppendLine(i.Value);
            }
            sbr.AppendLine();
            sbr.AppendLine("[注意]");
            sbr.AppendLine("命令与各参数使用空格隔开，如果需要使用空格，请使用“\\s”");
            sbr.AppendLine();
            sbr.AppendLine();
            sbr.AppendLine("------------------------------------");
            sbr.AppendLine(VersionName());

            return sbr.ToString();
        }

        public string VersionName()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.Append("字符串处理工具 - 脚本 v0.2  [墨云软件]");
            return sbr.ToString();

        }

        /// <summary>
        /// 工具栏按钮
        /// </summary>
        /// <param name="index"></param>
        public override void BtnClick(int index)
        {
            MessageBox.Show(index.ToString());
        }

		
		
    }
}
