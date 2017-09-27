using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringTools
{
    public partial class FrmIniteCode : Form
    {
        public FrmIniteCode()
        {
            InitializeComponent();

            txtCodeEditor.SetHighlighting("C#");
            //txtCodeEditor.IsReadOnly = true;

            txtCodeEditor.Text = Common.Code.IniteContent;
        }




        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder sbr = new StringBuilder();
            foreach (var item in txtCodeEditor.Text.Split("\r\n".ToArray()))
            {
                sbr.AppendLine("            " + item);
            }
            Common.Code.IniteContent = sbr.ToString();

            this.DialogResult = DialogResult.OK;
        }
    }
}
