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
    public partial class FrmCommandEditor : Form
    {

        /// <summary>
        /// 命令模型
        /// </summary>
        public Model.CommandModel cmd { get; set; }

        public bool IsUpdate { get; set; } = false;

        public string addCmdStr = "";
        public FrmCommandEditor()
        {
            InitializeComponent();
            txtPreview.SetHighlighting("C#");
            //txtPreview.IsReadOnly = true;
            cmd = new Model.CommandModel();


        }


        private void FrmCommandEditor_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = cmd;

            if (!string.IsNullOrEmpty(addCmdStr))
            {
                cmd.Name = addCmdStr;
            }

            txtPreview.Text = cmd.ToString(0);

            foreach (var item in Common.Code.GlobalVariableList)
            {
                treeTool.Nodes[2].Nodes.Add(new TreeNode(item, 0, 0));
            }
            foreach (var item in Common.Code.RefList)
            {
                treeTool.Nodes[3].Nodes.Add(new TreeNode(item, 5, 5));
            }
            foreach (var item in Common.Code.UsingAllList)
            {
                treeTool.Nodes[4].Nodes.Add(new TreeNode(item, 5, 5));
            }

            treeTool.ExpandAll();
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            txtPreview.Text = cmd.ToString(0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!IsUpdate && Common.Code.CommandList.Contains(cmd))
            {
                MessageBox.Show("已经存在该命令！");
                return;
            }
            cmd.Content = Tools.GetInnerCode(txtPreview.Text);
            if (!IsUpdate)
                Common.CmdAdd(cmd);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

            txtPreview.Text = cmd.ToString(0);
        }



        private void treeTool_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode node = e.Item as TreeNode;
            if (node == null)
                return;

            if (node.Parent == null || node.Parent.Index > 2)
                return;

            DoDragDrop(((TreeNode)e.Item).Text, DragDropEffects.Copy);
        }

        private void btnInte_Click(object sender, EventArgs e)
        {
            new FrmIniteCode().ShowDialog();
        }

        private void txtPreview_TextChanged(object sender, EventArgs e)
        {
            cmd.Content = Tools.GetInnerCode(txtPreview.Text);
        }
    }
}
