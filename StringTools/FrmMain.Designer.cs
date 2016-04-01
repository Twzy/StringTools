namespace StringTools
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNo1 = new System.Windows.Forms.ToolStripButton();
            this.btnNo2 = new System.Windows.Forms.ToolStripButton();
            this.btnNo3 = new System.Windows.Forms.ToolStripButton();
            this.btnNo4 = new System.Windows.Forms.ToolStripButton();
            this.btnNo5 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtCon = new ConsoleUI.ConsoleTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.labStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNo1,
            this.btnNo2,
            this.btnNo3,
            this.btnNo4,
            this.btnNo5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1072, 62);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // btnNo1
            // 
            this.btnNo1.AutoSize = false;
            this.btnNo1.Image = ((System.Drawing.Image)(resources.GetObject("btnNo1.Image")));
            this.btnNo1.ImageTransparentColor = System.Drawing.Color.White;
            this.btnNo1.Name = "btnNo1";
            this.btnNo1.Size = new System.Drawing.Size(54, 59);
            this.btnNo1.Tag = "0";
            this.btnNo1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNo2
            // 
            this.btnNo2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNo2.Image = ((System.Drawing.Image)(resources.GetObject("btnNo2.Image")));
            this.btnNo2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNo2.Name = "btnNo2";
            this.btnNo2.Size = new System.Drawing.Size(54, 59);
            this.btnNo2.Tag = "1";
            // 
            // btnNo3
            // 
            this.btnNo3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNo3.Image = ((System.Drawing.Image)(resources.GetObject("btnNo3.Image")));
            this.btnNo3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNo3.Name = "btnNo3";
            this.btnNo3.Size = new System.Drawing.Size(54, 59);
            this.btnNo3.Tag = "2";
            // 
            // btnNo4
            // 
            this.btnNo4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNo4.Image = ((System.Drawing.Image)(resources.GetObject("btnNo4.Image")));
            this.btnNo4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNo4.Name = "btnNo4";
            this.btnNo4.Size = new System.Drawing.Size(54, 59);
            this.btnNo4.Tag = "3";
            // 
            // btnNo5
            // 
            this.btnNo5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNo5.Image = ((System.Drawing.Image)(resources.GetObject("btnNo5.Image")));
            this.btnNo5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNo5.Name = "btnNo5";
            this.btnNo5.Size = new System.Drawing.Size(54, 59);
            this.btnNo5.Tag = "4";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtCon);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 531);
            this.splitContainer1.SplitterDistance = 556;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.txtInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer2.Size = new System.Drawing.Size(556, 531);
            this.splitContainer2.SplitterDistance = 208;
            this.splitContainer2.TabIndex = 0;
            // 
            // txtInput
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtInput, null);
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(554, 206);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            this.txtInput.WordWrap = false;
            // 
            // txtOutput
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtOutput, null);
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(554, 317);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            this.txtOutput.WordWrap = false;
            // 
            // txtCon
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCon, this.autocompleteMenu1);
            this.txtCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCon.HeadText = "";
            this.txtCon.IsAcceptInput = true;
            this.txtCon.Location = new System.Drawing.Point(0, 0);
            this.txtCon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(501, 529);
            this.txtCon.TabIndex = 0;
            this.txtCon.Text = "";
            this.txtCon.WordWrap = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ASPInclude.gif");
            this.imageList1.Images.SetKeyName(1, "icon_0.png");
            this.imageList1.Images.SetKeyName(2, "Cfparam.gif");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 20;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.UseAnimation = false;
            this.toolTip1.UseFading = false;
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.AppearInterval = 300;
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = this.imageList1;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.MaximumSize = new System.Drawing.Size(120, 200);
            this.autocompleteMenu1.MinFragmentLength = 1;
            this.autocompleteMenu1.TargetControlWrapper = null;
            this.autocompleteMenu1.Opening += new System.EventHandler<System.ComponentModel.CancelEventArgs>(this.autocompleteMenu1_Opening);
            this.autocompleteMenu1.Closing += new System.EventHandler(this.autocompleteMenu1_Closing);
            this.autocompleteMenu1.SelectChange += new System.EventHandler<AutocompleteMenuNS.SelectingEventArgs>(this.autocompleteMenu1_SelectChange);
            // 
            // labStatus
            // 
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 558);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符串处理工具";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.RichTextBox txtInput;
        public System.Windows.Forms.RichTextBox txtOutput;
        public ConsoleUI.ConsoleTextBox txtCon;
        public System.Windows.Forms.ToolStripButton btnNo1;
        public System.Windows.Forms.ToolStripButton btnNo2;
        public System.Windows.Forms.ToolStripButton btnNo3;
        public System.Windows.Forms.ToolStripButton btnNo4;
        public System.Windows.Forms.ToolStripButton btnNo5;
        public System.Windows.Forms.ToolStripStatusLabel labStatus;
    }
}

