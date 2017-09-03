using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace StringTools.Model
{
    /// <summary>
    /// 命令模型
    /// </summary>
    [Serializable, DefaultProperty("Name")]
    public class CommandModel
    {


        #region 基本信息

        /// <summary>
        /// 命令名称
        /// </summary>
        [Description("命令名称"), DisplayName("命令"), Category("基本信息"), DefaultValue("cmd_1")]
        public string Name { get; set; } = "cmd_1";

        /// <summary>
        /// 命令介绍
        /// </summary>
        [Description("命令描述信息"), DisplayName("描述"), Category("基本信息"), DefaultValue("命令描述信息")]
        public string Descption { get; set; } = "命令描述信息";

        /// <summary>
        /// 参数说明（每行对应一个参数的说明）
        /// </summary>
        [Description("参数说明"), DisplayName("参数说明"), Category("基本信息"),
            Editor(typeof(StringTools.PropertyFrm.PropertyListText), typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> ParamList { get; set; } = new List<string>();

        /// <summary>
        /// 对参数中通用符号进行转义处理，如\\s转为空格 \\n转为换行符等
        /// </summary>
        [Description("对参数中通用符号进行转义处理，如\\s转为空格 \\n转为换行符等"), DisplayName("参数转义"), Category("基本信息")]
        public bool ParamEscaped { get; set; } = true;

        /// <summary>
        /// 代码内容
        /// </summary>
        [Description("代码内容"), DisplayName("代码"), Category("基本信息"),
            Editor(typeof(StringTools.PropertyFrm.PropertyCodeText),
            typeof(System.Drawing.Design.UITypeEditor))]
        public string Content { get; set; } = "//ToDo:进行命令代码的实际编写";
        #endregion


        #region 扩展
        /// <summary>
        ///引用列表 外部引入 的脚本或类库
        /// </summary>
        [Description("引用列表 外部引入 的脚本或类库"), DisplayName("文件列表"), Category("扩展"),
            Editor(typeof(StringTools.PropertyFrm.PropertyListText), typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> RefList { get; set; } = new List<string>();
        /// <summary>
        /// using列表
        /// </summary>
        [Description("using列表, 使用C#语法规则，使用using 引入命名空间\r\n using System.IO;"), DisplayName("命名空间"), Category("扩展"),
            Editor(typeof(StringTools.PropertyFrm.PropertyListText), typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> UsingList { get; set; } = new List<string>();

        /// <summary>
        /// 全局变量
        /// </summary>
        [Description("全局变量"), DisplayName("全局变量"), Category("扩展"),
            Editor(typeof(StringTools.PropertyFrm.PropertyListText), typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> GlobalVariableList { get; set; } = new List<string>();
        #endregion

        public string ToString(int offset = 8)
        {
            string offsetSpace = "".PadLeft(offset, ' ');
            StringBuilder sbr = new StringBuilder();
            sbr.AppendLine(offsetSpace + "/// <summary>");
            sbr.AppendLine(offsetSpace + "/// " + Descption);

            if (ParamList.Count > 0)
            {
                sbr.AppendLine(offsetSpace + "/// 参数说明：");

                for (int i = 0; i < ParamList.Count; i++)
                {
                    sbr.AppendLine(offsetSpace + "/// [" + (i + 1).ToString() + "] " + ParamList[i]);

                }
            }


            sbr.AppendLine(offsetSpace + "/// </summary>");

            sbr.AppendLine(offsetSpace + "public void " + Name + "(string cmd,string[] args)");
            sbr.Append(offsetSpace + "{");

            string[] codeArry = string.IsNullOrEmpty(Content) ? new string[0] :
                Content.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in codeArry)
            {
                sbr.AppendLine(offsetSpace +  item);
            }

           // sbr.Append(Content);

            sbr.AppendLine(offsetSpace + "}");

            return sbr.ToString();
        }


        #region 重写 
        public override int GetHashCode()
        {
            return 1;
        }
        public override bool Equals(object obj)
        {
            return this.Name.ToLower() == (obj as CommandModel).Name.ToLower();
        }
        #endregion
    }
}
