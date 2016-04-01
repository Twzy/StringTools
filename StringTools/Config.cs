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
字符串处理工具v.02 -- [墨云软件]
------------------------------------
命令行工具，帮助请输入“help”或“？”
";
        /// <summary>
        /// 脚本文件
        /// </summary>
        public static string ScriptPath = Application.StartupPath + "\\Script\\ExecScript.cs";
    }
}
