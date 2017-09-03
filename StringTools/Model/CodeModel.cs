using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTools.Model
{
    [Serializable]
    public class CodeModel
    {


        public readonly string BASECLASS = "BaseCommand";
        public readonly string NAME = "ExecScript";
        public readonly string CMDLIST = "public Dictionary<string, string> GetCommandList()";
        public readonly string UnEscape = "public string[] UnEscape()";
        public readonly string NAMESPACE = "StringTools";
        public readonly string CONTENTS = @"
//墨云软件
//生成时间：" + DateTime.Now.ToLocalTime().ToString();


        public string VerDateTime { get; set; } = DateTime.Now.ToLocalTime().ToString();

        /// <summary>
        /// 引用 字符串
        /// </summary>
        private List<string> UsingList { get; set; } = new List<string>(){
                                                    "using System;",
                                                    "using System.Collections.Generic;",
                                                    "using System.Drawing;",
                                                    "using System.Linq;",
                                                    "using System.Text;",
                                                    "using System.Text.RegularExpressions;",
                                                    "using System.Windows.Forms; "};


        #region 外部引入
        public List<string> RefList
        {
            get
            {
                List<string> tmpList = new List<string>();
                foreach (var item in CommandList)
                {
                    tmpList.AddRange(item.RefList);
                }
                tmpList = tmpList.Distinct().ToList();


                return tmpList;
            }
        }

        /// <summary>
        /// 外部引入字符串
        /// </summary>
        public string RefStr
        {
            get
            {
                List<string> tmpList = new List<string>();
                foreach (var item in CommandList)
                {
                    tmpList.AddRange(item.RefList);
                }
                tmpList = tmpList.Distinct().ToList();


                var tmpRef = "";
                foreach (var u in tmpList)
                {
                    if (u.EndsWith(".dll"))
                    {
                        tmpRef += "//css_ref " + u + "\r\n";
                    }
                    else if (u.EndsWith(".cs"))
                    {
                        tmpRef += "//css_import " + u + "\r\n";
                    }

                }
                return tmpRef;
            }
        }

        #endregion

        #region 全局变量

        public List<string> GlobalVariableList
        {
            get
            {
                List<string> tmpList = new List<string>();
                foreach (var item in CommandList)
                {
                    tmpList.AddRange(item.GlobalVariableList);
                }
                tmpList = tmpList.Distinct().ToList();

                return tmpList;
            }
        }

        /// <summary>
        /// 全局变量
        /// </summary>
        public string GlobalVariable
        {
            get
            {
                List<string> tmpList = new List<string>();
                foreach (var item in CommandList)
                {
                    tmpList.AddRange(item.GlobalVariableList);
                }
                tmpList = tmpList.Distinct().ToList();


                var tmpUsing = "";
                foreach (var u in tmpList)
                {
                    tmpUsing += "        " + u + "\r\n";
                }
                return tmpUsing;
            }
        }
        #endregion


        #region using
        public List<string> UsingAllList
        {
            get
            {
                List<string> tmpList = new List<string>();
                tmpList.AddRange(UsingList);
                foreach (var item in CommandList)
                {
                    tmpList.AddRange(item.UsingList);
                }
                tmpList = tmpList.Distinct().ToList();
                return tmpList;
            }
        }

        /// <summary>
        ///Using 字符串
        /// </summary>
        public string Using
        {
            get
            {
                List<string> tmpList = new List<string>();
                tmpList.AddRange(UsingList);
                foreach (var item in CommandList)
                {
                    tmpList.AddRange(item.UsingList);
                }
                tmpList = tmpList.Distinct().ToList();

                var tmpUsing = "";
                foreach (var u in tmpList)
                {
                    tmpUsing += u + "\r\n";
                }
                return tmpUsing;
            }
        }
        #endregion

        /// <summary>
        /// 命令列表
        /// </summary>
        public List<CommandModel> CommandList { get; set; } = new List<CommandModel>();






        /// <summary>
        /// 显示内容
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendLine(CONTENTS);

            //引用列表
            sbr.AppendLine("\r\n//--------------------------\r\n");
            sbr.AppendLine(RefStr);

            sbr.AppendLine();
            sbr.AppendLine(Using);
            sbr.AppendLine();
            sbr.AppendLine("namespace " + NAMESPACE);
            sbr.AppendLine("{");

            sbr.AppendLine("    public class " + NAME + " : " + BASECLASS);
            sbr.AppendLine("    {");

            sbr.AppendLine();
            sbr.AppendLine(GlobalVariable);
            sbr.AppendLine();


            //命令列表
            foreach (var item in CommandList)
            {
                sbr.AppendLine(item.ToString());
            }


            //参数非转义命令列表
            sbr.AppendLine("        /// <summary>");
            sbr.AppendLine("        /// 参数非转义命令列表");
            sbr.AppendLine("        /// </summary>");
            sbr.AppendLine("        " + UnEscape);
            sbr.AppendLine("        {");
            sbr.AppendLine("            List<string> tmpArry=new List<string>();");
            foreach (var item in CommandList)
            {
                if (!item.ParamEscaped)
                {
                    sbr.AppendLine("            tmpArry.Add(\"" + item.Name + "\");");
                }
            }
            sbr.AppendLine("            return tmpArry.ToArray();");
            sbr.AppendLine("        }");
            sbr.AppendLine();


            //命令行信息
            sbr.AppendLine("        /// <summary>");
            sbr.AppendLine("        /// 命令行信息");
            sbr.AppendLine("        /// </summary>");
            sbr.AppendLine("        " + CMDLIST);
            sbr.AppendLine("        {");
            sbr.AppendLine("           var  CommandList = new Dictionary<string, string>();");
            foreach (var item in CommandList)
            {
                StringBuilder sbrTip = new StringBuilder();
                string arry = "";
                string arrList = "";

                for (int i = 0; i < item.ParamList.Count; i++)
                {
                    arry += " [" + (i + 1).ToString() + "]";
                    arrList += " [" + (i + 1).ToString() + "] " + item.ParamList[i] + "\\r\\n";
                }
                sbrTip.AppendLine(item.Name + " " + arry + arrList);


                sbr.AppendLine("           CommandList.Add(\"" + item.Name + "\",\"" + item.Name + " " + arry + " -- " + item.Descption + "\\r\\n" + arrList + "\");");

            }
            sbr.AppendLine("           return CommandList;");

            sbr.AppendLine("        }");

            sbr.AppendLine("    }");
            sbr.AppendLine("}");

            return sbr.ToString();
        }


    }
}
