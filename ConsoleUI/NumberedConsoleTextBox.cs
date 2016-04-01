using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ConsoleUI
{
    public partial class NumberedConsoleTextBox : UserControl
    {
        public NumberedConsoleTextBox()
        {
            InitializeComponent();
            baseTextBox.ReadCommandtEvent += new OnMessageArrivalHandler(consoleTextBox1_ReadCommandtEvent);
            UpStyle();
        }

        void consoleTextBox1_ReadCommandtEvent(object sender, ConsoleEditEventArgs e)
        {
            if (ReadCommandtEvent != null)
            {
                ReadCommandtEvent(this, e);
            }
        }
        private void UpStyle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        /// <summary>
        /// 发送数据的事件
        /// </summary>
        public event OnMessageArrivalHandler ReadCommandtEvent;

        #region 相关操作
        private void updateNumberLabel()
        {
            WinAPI.SendMessage(this.Handle, WinAPI.WM_SETREDRAW, 0, IntPtr.Zero);
            WinAPI.SendMessage(numberLabel.Handle, WinAPI.WM_SETREDRAW, 0, IntPtr.Zero);
            Point pos = new Point(0, 0);
            int firstIndex = baseTextBox.GetCharIndexFromPosition(pos);
            int firstLine = baseTextBox.GetLineFromCharIndex(firstIndex);

            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = baseTextBox.GetCharIndexFromPosition(pos);
            int lastLine = baseTextBox.GetLineFromCharIndex(lastIndex);

            pos = baseTextBox.GetPositionFromCharIndex(lastIndex);

            numberLabel.Text = "";
            for (int i = firstLine; i <= lastLine + 1; i++)
            {
                numberLabel.Text += i + 1 + "\n";
            }
            WinAPI.SendMessage(numberLabel.Handle, WinAPI.WM_SETREDRAW, 1, IntPtr.Zero);
            WinAPI.SendMessage(this.Handle, WinAPI.WM_SETREDRAW, 1, IntPtr.Zero);
            this.Refresh();
        }
        private void consoleTextBox1_VScroll(object sender, EventArgs e)
        {
            int d = baseTextBox.GetPositionFromCharIndex(0).Y % (baseTextBox.Font.Height + 1);
            numberLabel.Location = new Point(0, d);

            updateNumberLabel();
        }

        private void consoleTextBox1_Resize(object sender, EventArgs e)
        {
            consoleTextBox1_VScroll(null, null);
        }

        private void consoleTextBox1_FontChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
            consoleTextBox1_VScroll(null, null);
        }
        private void consoleTextBox1_TextChanged(object sender, EventArgs e)
        {
            updateNumberLabel();
        }
        #endregion

        /// <summary>
        /// 字体
        /// </summary>
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                baseTextBox.Font = value;
                numberLabel.Font = value;
            }
        }

        /// <summary>
        /// 行号条背景颜色
        /// </summary>
        public Color NumberBarBackColor
        {
            get
            {
                return numberLabel.BackColor;
            }
            set
            {
                numberLabel.BackColor = value;
            }
        }

        /// <summary>
        /// 行号条字体颜色
        /// </summary>
        public Color NumberBarForeColor
        {
            get
            {
                return numberLabel.ForeColor;
            }
            set
            {
                numberLabel.ForeColor = value;
            }
        }
        /// <summary>
        /// 分割线颜色
        /// </summary>
        public Color SplitColor
        {
            get
            {
                return splitContainer1.BackColor;
            }
            set
            {
                splitContainer1.BackColor = value;
            }
        }
        /// <summary>
        /// 输入框文本颜色
        /// </summary>
        public Color TextBoxForeColor
        {
            get
            {
                return baseTextBox.ForeColor;
            }
            set
            {
                baseTextBox.ForeColor = value;
            }
        }

        /// <summary>
        /// 输入框背景颜色
        /// </summary>
        public Color TextBoxBackColor
        {
            get
            {
                return baseTextBox.BackColor;
            }
            set
            {
                baseTextBox.BackColor = value;
            }
        }
        /// <summary>
        ///当前数据行号
        /// </summary>
        public int InputLineNum
        {
            get
            {
                return baseTextBox.InputLineNum;
            }
        }
        /// <summary>
        /// 用于表示命令行前缀
        /// </summary>
        public string HeadText
        {
            get
            {
                return baseTextBox._headText;
            }
            set
            {
                baseTextBox._headText = value;
            }
        }
        /// <summary>
        /// 在屏幕上显示字符串
        /// </summary>
        /// <param name="msg">字符串</param>
        public void Write(string msg)
        {
            if (baseTextBox.Lines.Length != 0 && !string.IsNullOrEmpty(msg))
            {
                baseTextBox.AppendText("\n" + msg);
            }
            else
            {
                baseTextBox.AppendText(msg);
            }

            baseTextBox.AddNewLine();
        }
        /// <summary>
        /// 增加一行
        /// </summary>
        public void Write()
        {
            baseTextBox.AddNewLine();
        }



    }


}
