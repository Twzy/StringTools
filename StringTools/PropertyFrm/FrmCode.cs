using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringTools.PropertyFrm
{
    public partial class FrmCode : Form
    {
        public FrmCode()
        {
            InitializeComponent();

            txtCodeEditor.SetHighlighting("C#");
            //txtCodeEditor.IsReadOnly = true;
        }

        public void LoadCode(string code)
        {
            txtCodeEditor.Text = code;
        }

        public string GetCode()
        {
            return txtCodeEditor.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
