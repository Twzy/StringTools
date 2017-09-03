using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringTools
{
    /// <summary>
    /// 控制信息出入输出记录
    /// </summary>
    /// <param name="t"></param>
    /// <param name="msg"></param>
    public delegate void CmdLogHandler(IOType t, string msg);

    /// <summary>
    /// 输入输出信息
    /// </summary>
    [Serializable]
    public enum IOType
    {
        /// <summary>
        /// 从输出窗口读取
        /// </summary>
        TxtOut_R,
        /// <summary>
        /// 输出窗口写入
        /// </summary>
        TxtOut_W,
        /// <summary>
        /// 出入窗口读取
        /// </summary>
        TxtIn_R,
        /// <summary>
        /// 出入窗口写入
        /// </summary>
        TxtIn_W,
        /// <summary>
        /// 控制台输出
        /// </summary>
        Cmd
    }
}
