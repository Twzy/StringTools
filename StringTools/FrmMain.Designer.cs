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
            this.labStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.SP1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtCon = new ConsoleUI.ConsoleTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP1)).BeginInit();
            this.SP1.Panel1.SuspendLayout();
            this.SP1.Panel2.SuspendLayout();
            this.SP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(849, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labStatus
            // 
            this.labStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // SP1
            // 
            this.SP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SP1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP1.Location = new System.Drawing.Point(0, 0);
            this.SP1.Margin = new System.Windows.Forms.Padding(0);
            this.SP1.Name = "SP1";
            // 
            // SP1.Panel1
            // 
            this.SP1.Panel1.Controls.Add(this.splitContainer2);
            this.SP1.Panel1Collapsed = true;
            // 
            // SP1.Panel2
            // 
            this.SP1.Panel2.Controls.Add(this.txtCon);
            this.SP1.Size = new System.Drawing.Size(1633, 846);
            this.SP1.SplitterDistance = 851;
            this.SP1.SplitterWidth = 5;
            this.SP1.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.splitContainer2.Panel1MinSize = 300;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtOutput);
            this.splitContainer2.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer2.Panel2MinSize = 300;
            this.splitContainer2.Size = new System.Drawing.Size(851, 846);
            this.splitContainer2.SplitterDistance = 366;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 9;
            // 
            // txtInput
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtInput, null);
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInput.Location = new System.Drawing.Point(0, 0);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(849, 364);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "";
            this.txtInput.WordWrap = false;
            this.txtInput.AcceptsTab = true;
            // 
            // txtOutput
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtOutput, null);
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(0);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(849, 451);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            this.txtOutput.WordWrap = false;
            this.txtOutput.AcceptsTab = true;
            // 
            // txtCon
            // 
            this.autocompleteMenu1.SetAutocompleteMenu(this.txtCon, this.autocompleteMenu1);
            this.txtCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCon.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtCon.HeadText = "";
            this.txtCon.IsAcceptInput = true;
            this.txtCon.Location = new System.Drawing.Point(0, 0);
            this.txtCon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(1631, 844);
            this.txtCon.TabIndex = 0;
            this.txtCon.Text = "";
            this.txtCon.WordWrap = false;
            this.txtCon.AcceptsTab = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ASPInclude.gif");
            this.imageList1.Images.SetKeyName(1, "T_LineNumbers_Sm.png");
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
            this.autocompleteMenu1.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocompleteMenu1.ImageList = this.imageList1;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.MaximumSize = new System.Drawing.Size(120, 200);
            this.autocompleteMenu1.MinFragmentLength = 1;
            this.autocompleteMenu1.TargetControlWrapper = null;
            this.autocompleteMenu1.Opening += new System.EventHandler<System.ComponentModel.CancelEventArgs>(this.autocompleteMenu1_Opening);
            this.autocompleteMenu1.Closing += new System.EventHandler(this.autocompleteMenu1_Closing);
            this.autocompleteMenu1.SelectChange += new System.EventHandler<AutocompleteMenuNS.SelectingEventArgs>(this.autocompleteMenu1_SelectChange);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1633, 846);
            this.Controls.Add(this.SP1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字符串处理工具";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.SP1.Panel1.ResumeLayout(false);
            this.SP1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SP1)).EndInit();
            this.SP1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.RichTextBox txtInput;
        public System.Windows.Forms.RichTextBox txtOutput;
        public ConsoleUI.ConsoleTextBox txtCon;
        public System.Windows.Forms.ToolStripStatusLabel labStatus;
        public System.Windows.Forms.SplitContainer SP1;
    }
}

