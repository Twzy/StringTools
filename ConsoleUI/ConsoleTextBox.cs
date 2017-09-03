using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
namespace ConsoleUI
{
    public class ConsoleTextBox : RichTextBox
    {
        public ConsoleTextBox()
        {
            this.KeyDown += new KeyEventHandler(ConsoleTextBox_KeyDown);
            this.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
            this.WordWrap = false;

            IsAcceptInput = true;
        }

        public bool IsAcceptInput { get; set; }




        internal string _headText = "";
        string CommandStr = "";//获取的命令
        List<string> commandList = new List<string>();

        #region 属性与事件
        /// <summary>
        /// 用于表示命令行前缀
        /// </summary>
        public string HeadText { get { return _headText; } set { _headText = value; } }
        /// <summary>
        /// 当前可以输入命令的行号
        /// </summary>
        public int InputLineNum { get; private set; }

        /// <summary>
        /// 发送数据的事件
        /// </summary>
        public event OnMessageArrivalHandler ReadCommandtEvent;

        #endregion

        /// <summary>
        /// 用于插入头部数据,配合HeadText使用
        /// </summary>
        private void InsertHeadText()
        {

            this.AppendText(HeadText);
        }
        /// <summary>
        /// 增加命了前置
        /// </summary>
        internal void AddNewLine()
        {
            //命令为空
            CommandStr = string.Empty;
            //加入新的行
            this.AppendText("\n");
            InsertHeadText();
            InputLineNum = this.Lines.Length - 1;
            this.Focus();

        }
        //输出数据触发器
        private void ReadCommadeText()
        {
            if (ReadCommandtEvent != null)
            {
                if (!string.IsNullOrEmpty(CommandStr) && !commandList.Contains(CommandStr))
                {
                    commandList.Add(CommandStr);
                    ItemIndex++;
                }
                ReadCommandtEvent(this, ConsoleEditEventArgs.CreatEventArgs(CommandStr));
            }
        }


        private void UpdateLog(bool isUp)
        {
            if (commandList.Count == 0)
                return;
            string tmpStr = this.Text;
            int offset = tmpStr.LastIndexOf(HeadText);
            offset += HeadText.Length;

            WinAPI.SendMessage(this.Handle, WinAPI.WM_SETREDRAW, 0, IntPtr.Zero);

            if (offset == tmpStr.Length)
            {
                this.Text = tmpStr + GetItemStr(isUp);
            }
            else
            {
                tmpStr = tmpStr.Remove(offset);
                this.Text = tmpStr + GetItemStr(isUp);
            }

            WinAPI.SendMessage(this.Handle, WinAPI.WM_SETREDRAW, 1, IntPtr.Zero);
            this.Refresh();
        }
        int ItemIndex = 0;
        private string GetItemStr(bool isUp)
        {

            if (isUp)
            {
                ItemIndex--;
                if (ItemIndex <= 0)
                {
                    ItemIndex = 0;
                }
                return commandList[ItemIndex];
            }
            else
            {
                ItemIndex++;
                if (ItemIndex >= commandList.Count)
                {
                    ItemIndex = commandList.Count - 1;
                    return "";
                }
                return commandList[ItemIndex];
            }
        }

        void ConsoleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.TextLength == 0)
            {
                e.Handled = true;
                return;
            }
            int currentLine = this.GetLineFromCharIndex(this.SelectionStart);
            if (currentLine < InputLineNum)
            {
                this.SelectionStart = this.TextLength;
                e.Handled = true;
                return;
            }

            //操作当前行
            int lineFristCharOffset = this.GetFirstCharIndexFromLine(InputLineNum);//当前行第一个字母偏移量
            int currentCharOffset = this.SelectionStart;//当前光标偏移量
            int spanHeadLength = currentCharOffset - lineFristCharOffset;//计算当前行的光标的偏移量
            if (spanHeadLength < HeadText.Length)
            {
                this.SelectionStart = this.TextLength;
                e.Handled = true;
                return;
            }
            else if (spanHeadLength == HeadText.Length && (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left))
            {
                e.Handled = true;
                return;
            }

            if (IsAcceptInput)
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        if (string.IsNullOrEmpty(HeadText))
                            CommandStr = this.Lines[InputLineNum];
                        else
                            CommandStr = this.Lines[InputLineNum].Replace(HeadText, "");
                        ReadCommadeText();//传输命令
                        e.Handled = true;
                        break;
                    case Keys.Up:
                        UpdateLog(true);
                        this.SelectionStart = this.TextLength;
                        e.Handled = true;
                        break;
                    case Keys.Down:
                        UpdateLog(false);
                        this.SelectionStart = this.TextLength;
                        e.Handled = true;
                        break;
                }
            }
            else
            {
                if (e.KeyCode != Keys.Back)
                    e.Handled = true;
            }

        }
        /// <summary>
        /// 在屏幕上显示字符串
        /// </summary>
        /// <param name="msg">字符串</param>
        public void Write(string msg, bool IsAddNewLine = true)
        {

            if (this.Lines.Length != 0 && !string.IsNullOrEmpty(msg))
            {
                this.AppendText("\n" + msg);
            }
            else
            {
                this.AppendText(msg);
            }
            if (IsAddNewLine)
                AddNewLine();
        }

        //public  void Clear()
        //{

        //    base.Clear();
        //    //AddNewLine();
        //}
        /// <summary>
        /// 只增加一行
        /// </summary>
        public void Write()
        {
            AddNewLine();
        }




        private class paintHelper : Control
        {
            public void DefaultWndProc(ref Message m)
            {
                this.DefWndProc(ref m);
            }
        }

        private const int WM_PAINT = 0x000F;
        private int lockPaint;
        private bool needPaint;
        private paintHelper pHelp = new paintHelper();

        public void BeginUpdate()
        {
            lockPaint++;
        }

        public void EndUpdate()
        {
            lockPaint--;
            if (lockPaint <= 0)
            {
                lockPaint = 0;
                if (needPaint)
                {
                    this.Refresh();
                    needPaint = false;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_PAINT:
                    if (lockPaint <= 0)
                    {
                        base.WndProc(ref m);
                    }
                    else
                    {
                        needPaint = true;
                        pHelp.DefaultWndProc(ref m);
                    }
                    return;
            }

            base.WndProc(ref m);
        }
    }
}
