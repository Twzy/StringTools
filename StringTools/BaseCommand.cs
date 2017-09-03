using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace StringTools
{
    /// <summary>
    /// 脚本所要集成的父类，提供一些基本方法
    /// </summary>
    public class BaseCommand
    {

        /// <summary>
        /// 窗体主体，方便在以后开发中可以通过脚本方式直接调用窗体控件，如上面没实现任何功能的按钮
        /// </summary>
        public FrmMain CurrMainForm { get; set; }
        /// <summary>
        /// 出入输出记录
        /// </summary>
        public CmdLogHandler logHandler { get; set; }


        /// <summary>
        /// 输入记录列表
        /// </summary>
        public List<string> ILs = new List<string>();

        /// <summary>
        /// 输入文本
        /// </summary>
        public string I
        {
            get
            {
                logHandler(IOType.TxtIn_R, CurrMainForm.txtInput.Text);

                if (ILs.Contains(CurrMainForm.txtInput.Text))
                {
                    ILs.Remove(CurrMainForm.txtInput.Text);
                }
                ILs.Insert(0, CurrMainForm.txtInput.Text);
                return CurrMainForm.txtInput.Text;
            }
            set
            {
                logHandler(IOType.TxtIn_W, value);
                CurrMainForm.txtInput.Text = value;
            }
        }

        /// <summary>
        /// 输出文本
        /// </summary>
        public string O
        {
            get
            {

                logHandler(IOType.TxtOut_R, CurrMainForm.txtOutput.Text);
                return CurrMainForm.txtOutput.Text;
            }
            set
            {
                logHandler(IOType.TxtOut_W, value);
                CurrMainForm.txtOutput.Text = value;
            }
        }
        /// <summary>
        /// 状态栏 文本
        /// </summary>
        public string StatusText
        {
            get
            {
                return this.CurrMainForm.labStatus.Text;
            }
            set
            {
                this.CurrMainForm.labStatus.Text = value;
            }
        }

        /// <summary>
        /// 向输出文本框写入文本
        /// </summary>
        /// <param name="message"></param>
        public virtual void Write(string message)
        {
            O = message;
        }

        /// <summary>
        /// 清理命令行控件内容
        /// </summary>
        public void ClearCommand()
        {
            CurrMainForm.txtCon.Clear();
        }

        /// <summary>
        /// 向命令行控件写信息
        /// </summary>
        /// <param name="msg"></param>
        public virtual void Cmd(string msg)
        {
            logHandler(IOType.Cmd, msg);
            CurrMainForm.txtCon.Write(msg, false);
        }
    }
}
