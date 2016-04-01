using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StringTools
{
    /// <summary>
    /// 脚本所要是现实的接口
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 命令执行方法
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="inputText"></param>
        void Exec(string cmd, string inputText);
        /// <summary>
        /// 帮助文档方法
        /// </summary>
        /// <returns></returns>
        string HelpDoc();
        /// <summary>
        /// 命令列表，继承 BaseCommand 后默认实现
        /// </summary>
        Dictionary<string, string> CommandList { get; }
        /// <summary>
        /// 主界面 ，继承 BaseCommand 后默认实现（脚本设置无效）
        /// </summary>
        FrmMain CurrMainForm { get; set; }
        /// <summary>
        /// 命令行默认字体颜色，继承 BaseCommand 后默认实现（脚本设置无效）
        /// </summary>
        Color DefaultColor { get; set; }
    }
}
