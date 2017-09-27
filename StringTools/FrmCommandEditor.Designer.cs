namespace StringTools
{
    partial class FrmCommandEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("=I;");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("O=  ;");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cmd(\"\");");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("if(args.Length > 0){}");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("StatusText=;");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Common.Code");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Common.Document");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("常规", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tools.RepEscape( xxx );");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tools.StrShort(xxx);");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("WriteByXML<T>(m,path);");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("ReadByXML<T>(path)");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("var str = Tools.ArgsCombin(args);");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("var str =Tools. getContent(cmd);");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("工具", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("全局变量", 4, 4);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("外部引入", 2, 2);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("using", 2, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommandEditor));
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.txtPreview = new ICSharpCode.TextEditor.TextEditorControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeTool = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnInte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(958, 620);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(67, 22);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "预 览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(1050, 620);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 22);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1138, 620);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 22);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取 消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid1.Size = new System.Drawing.Size(272, 590);
            this.propertyGrid1.TabIndex = 8;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // txtPreview
            // 
            this.txtPreview.AllowDrop = true;
            this.txtPreview.AutoScroll = true;
            this.txtPreview.ConvertTabsToSpaces = true;
            this.txtPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPreview.IsReadOnly = false;
            this.txtPreview.Location = new System.Drawing.Point(0, 0);
            this.txtPreview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ShowVRuler = false;
            this.txtPreview.Size = new System.Drawing.Size(641, 590);
            this.txtPreview.TabIndex = 5;
            this.txtPreview.TextChanged += new System.EventHandler(this.txtPreview_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(9, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1205, 592);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtPreview);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.treeTool);
            this.splitContainer2.Size = new System.Drawing.Size(928, 592);
            this.splitContainer2.SplitterDistance = 643;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeTool
            // 
            this.treeTool.AllowDrop = true;
            this.treeTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTool.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.treeTool.FullRowSelect = true;
            this.treeTool.HotTracking = true;
            this.treeTool.ImageIndex = 0;
            this.treeTool.ImageList = this.imageList1;
            this.treeTool.Location = new System.Drawing.Point(0, 0);
            this.treeTool.Name = "treeTool";
            treeNode1.Name = "节点3";
            treeNode1.Text = "=I;";
            treeNode2.Name = "节点4";
            treeNode2.Text = "O=  ;";
            treeNode3.Name = "节点5";
            treeNode3.Text = "Cmd(\"\");";
            treeNode4.Name = "节点6";
            treeNode4.Text = "if(args.Length > 0){}";
            treeNode5.Name = "节点8";
            treeNode5.Text = "StatusText=;";
            treeNode6.Name = "节点0";
            treeNode6.Text = "Common.Code";
            treeNode7.Name = "节点1";
            treeNode7.Text = "Common.Document";
            treeNode8.ImageIndex = 4;
            treeNode8.Name = "trCom";
            treeNode8.SelectedImageIndex = 4;
            treeNode8.Text = "常规";
            treeNode9.Name = "节点9";
            treeNode9.Text = "Tools.RepEscape( xxx );";
            treeNode10.Name = "节点10";
            treeNode10.Text = "Tools.StrShort(xxx);";
            treeNode11.Name = "节点11";
            treeNode11.Text = "WriteByXML<T>(m,path);";
            treeNode12.Name = "节点12";
            treeNode12.Text = "ReadByXML<T>(path)";
            treeNode13.Name = "节点0";
            treeNode13.Text = "var str = Tools.ArgsCombin(args);";
            treeNode14.Name = "节点1";
            treeNode14.Text = "var str =Tools. getContent(cmd);";
            treeNode15.ImageIndex = 4;
            treeNode15.Name = "trTool";
            treeNode15.SelectedImageIndex = 4;
            treeNode15.Text = "工具";
            treeNode16.ImageIndex = 4;
            treeNode16.Name = "trgalVal";
            treeNode16.SelectedImageIndex = 4;
            treeNode16.Text = "全局变量";
            treeNode17.ImageIndex = 2;
            treeNode17.Name = "节点13";
            treeNode17.SelectedImageIndex = 2;
            treeNode17.Text = "外部引入";
            treeNode18.ImageIndex = 2;
            treeNode18.Name = "节点14";
            treeNode18.SelectedImageIndex = 2;
            treeNode18.Text = "using";
            this.treeTool.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            this.treeTool.SelectedImageIndex = 0;
            this.treeTool.Size = new System.Drawing.Size(279, 590);
            this.treeTool.TabIndex = 0;
            this.treeTool.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeTool_ItemDrag);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "LineNumbers.png");
            this.imageList1.Images.SetKeyName(1, "currLine.png");
            this.imageList1.Images.SetKeyName(2, "link_16x16.png");
            this.imageList1.Images.SetKeyName(3, "T_SelectParent_Sm_N.png");
            this.imageList1.Images.SetKeyName(4, "T_Comment_Sm_N.png");
            this.imageList1.Images.SetKeyName(5, "T_WrapTag_Sm_N.png");
            // 
            // btnInte
            // 
            this.btnInte.Location = new System.Drawing.Point(10, 620);
            this.btnInte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInte.Name = "btnInte";
            this.btnInte.Size = new System.Drawing.Size(86, 22);
            this.btnInte.TabIndex = 10;
            this.btnInte.Text = "初始化方法";
            this.btnInte.UseVisualStyleBackColor = true;
            this.btnInte.Click += new System.EventHandler(this.btnInte_Click);
            // 
            // FrmCommandEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 662);
            this.Controls.Add(this.btnInte);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCommandEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "命令编辑器";
            this.Load += new System.EventHandler(this.FrmCommandEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private ICSharpCode.TextEditor.TextEditorControl txtPreview;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeTool;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnInte;
    }
}