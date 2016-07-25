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
        /// 用于记忆当前命令行控件的字体颜色
        /// </summary>
        public Color DefaultColor { get; set; }
        /// <summary>
        /// 命令行字典
        /// </summary>
        public Dictionary<string, string> CommandList { get; set; }


        /// <summary>
        /// 输入文本框
        /// </summary>
        public RichTextBox TxtInput
        {
            get
            {
                if (this.CurrMainForm != null)
                {
                    return this.CurrMainForm.txtInput;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 输出文本框
        /// </summary>
        public RichTextBox TxtOutput
        {
            get
            {
                if (this.CurrMainForm != null)
                {
                    return this.CurrMainForm.txtOutput;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 状态栏
        /// </summary>
        public ToolStripStatusLabel LabStatus
        {
            get
            {
                if (this.CurrMainForm != null)
                {
                    return this.CurrMainForm.labStatus;
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 向输出文本框写入文本
        /// </summary>
        /// <param name="message"></param>
        public virtual void Print(string message)
        {
            CurrMainForm.txtOutput.Text = message;
            CurrMainForm.txtCon.Write();
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
        public virtual void WriteCommand(string msg = "")
        {
            CurrMainForm.txtCon.Write(msg);
        }

        /// <summary>
        /// 向命令行控件写信息，并带有字体颜色
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="fontColor"></param>
        public virtual void WriteCommand(string msg, Color fontColor)
        {
            CurrMainForm.txtCon.SelectionColor = fontColor;
            CurrMainForm.txtCon.Write(msg);
            CurrMainForm.txtCon.SelectionColor = DefaultColor;
        }

        /// <summary>
        /// 初始化5个按钮的单击事件
        /// </summary>
        internal void IniteBtn()
        {
         
        }
        /// <summary>
        /// 单击事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnbtnNo_Click(object sender, EventArgs e)
        {
            BtnClick(int.Parse((sender as ToolStripButton).Tag.ToString()));
        }
        /// <summary>
        /// 可重载方法，方便脚本中处理对应的事件方法
        /// </summary>
        /// <param name="index"></param>
        public virtual void BtnClick(int index)
        {

        }
    }
}
