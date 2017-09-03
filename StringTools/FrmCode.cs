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
    public partial class FrmCode : Form
    {
        public FrmCode()
        {
            InitializeComponent();

            txtPreview.SetHighlighting("C#");
            txtPreview.IsReadOnly = true;
            LoadCommand();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCommandEditor fmc = new FrmCommandEditor();
            if (fmc.ShowDialog() == DialogResult.OK)
            {
                AddCommand(fmc.cmd);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {

            if (lsvCmd.SelectedItems.Count == 0)
            {
                return;
            }
            FrmCommandEditor fmc = new FrmCommandEditor();
            fmc.IsUpdate = true;
            fmc.cmd = Common.Code.CommandList[lsvCmd.SelectedItems[0].Index];
            if (fmc.ShowDialog() == DialogResult.OK)
            {
                UpdateCommand(fmc.cmd);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvCmd.SelectedItems.Count == 0)
            {
                return;
            }
            var result = MessageBox.Show("是否删除 " + lsvCmd.SelectedItems[0].SubItems[0].Text + " 命令 ", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DeleteCommand(Common.Code.CommandList[lsvCmd.SelectedItems[0].Index]);
            }

        }




        private void btnPreview_Click(object sender, EventArgs e)
        {
            txtPreview.Text = Common.Code.ToString();

            System.IO.File.WriteAllText(Config.ScriptPath, txtPreview.Text);

            Common.SaveCodeMode();
        }


        #region 增删改查

        /// <summary>
        /// 加载配置信息
        /// </summary>
        private void LoadCommand()
        {
            lsvCmd.Items.Clear();
            foreach (var item in Common.Code.CommandList)
            {
                AddCommand(item, true);
            }
        }


        public bool AddCommand(Model.CommandModel cmd, bool isAddUIOnly = false)
        {

            ListViewItem item = new ListViewItem(cmd.Name, 0);
            item.SubItems.Add(cmd.Descption);
            lsvCmd.Items.Add(item);

            return true;
        }

        public bool UpdateCommand(Model.CommandModel cmd)
        {

            ListViewItem tagNode = null;
            foreach (ListViewItem n in lsvCmd.Items)
            {
                if (n.SubItems[0].Text == cmd.Name)
                {
                    tagNode = n;
                    break;
                }
            }
            if (tagNode == null)
            {
                throw new ArgumentException("所要更新的参数不存在");
            }

            tagNode.SubItems[0].Text = cmd.Name;
            tagNode.SubItems[1].Text = cmd.Descption;


            return true;
        }

        public bool DeleteCommand(Model.CommandModel cmd)
        {

            foreach (ListViewItem n in lsvCmd.Items)
            {
                if (n.SubItems[0].Text == cmd.Name)
                {
                    lsvCmd.Items.Remove(n);
                    break;
                }
            }
            Common.CmdDel(cmd);

            return true;
        }


        #endregion

        private void lsvCmd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCmd.SelectedItems.Count == 0)
            {
                return;
            }

            txtPreview.Text = Common.Code.CommandList[lsvCmd.SelectedItems[0].Index].ToString(0);

        }
    }
}
