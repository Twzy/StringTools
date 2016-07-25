using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringTools
{

    /// <summary>
    /// 配置类
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 命令行头部信息
        /// </summary>
        public static string headStr = @"------------------------------------
StringTools v.02 -- [墨云软件]
------------------------------------
cmd，input “help” or “？” for help
";
        /// <summary>
        /// 脚本文件
        /// </summary>
        public static string ScriptPath = Application.StartupPath + "\\Script\\ExecScript.cs";
    }
}
