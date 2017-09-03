﻿using System;
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
StringTools v 1.00 -- [墨云软件]
------------------------------------
字符串处理工具，输入 “help” 或 “?” 获取帮助信息";
        /// <summary>
        /// 脚本文件
        /// </summary>
        public static string ScriptPath = Application.StartupPath + "\\Script\\ExecScript.cs";

        public static string CodeMode = Application.StartupPath + "\\codeMode.xml";

        public static string LogDir = Application.StartupPath + "\\log";

        public static string Help = Properties.Resources.helpContent;
    }
}
