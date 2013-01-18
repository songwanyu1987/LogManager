namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pause = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.perbankPage = new System.Windows.Forms.TabPage();
            this.perbankTextBox = new System.Windows.Forms.TextBox();
            this.corporbankPage = new System.Windows.Forms.TabPage();
            this.corporTextBox = new System.Windows.Forms.TextBox();
            this.innermanagePage = new System.Windows.Forms.TabPage();
            this.innermanageTextBox = new System.Windows.Forms.TextBox();
            this.serviceControllerPage = new System.Windows.Forms.TabPage();
            this.serviceControllerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.perbankPage.SuspendLayout();
            this.corporbankPage.SuspendLayout();
            this.innermanagePage.SuspendLayout();
            this.serviceControllerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pause);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(60, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pause
            // 
            this.pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pause.Location = new System.Drawing.Point(190, 34);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 35);
            this.pause.TabIndex = 1;
            this.pause.Text = "暂停";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // start
            // 
            this.start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(52, 34);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 35);
            this.start.TabIndex = 0;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.perbankPage);
            this.tabControl1.Controls.Add(this.corporbankPage);
            this.tabControl1.Controls.Add(this.innermanagePage);
            this.tabControl1.Controls.Add(this.serviceControllerPage);
            this.tabControl1.Location = new System.Drawing.Point(60, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 357);
            this.tabControl1.TabIndex = 1;
            // 
            // perbankPage
            // 
            this.perbankPage.Controls.Add(this.perbankTextBox);
            this.perbankPage.Location = new System.Drawing.Point(4, 22);
            this.perbankPage.Name = "perbankPage";
            this.perbankPage.Padding = new System.Windows.Forms.Padding(3);
            this.perbankPage.Size = new System.Drawing.Size(876, 331);
            this.perbankPage.TabIndex = 0;
            this.perbankPage.Text = "个人网银日志";
            this.perbankPage.UseVisualStyleBackColor = true;
            this.perbankPage.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // perbankTextBox
            // 
            this.perbankTextBox.Location = new System.Drawing.Point(0, 0);
            this.perbankTextBox.Multiline = true;
            this.perbankTextBox.Name = "perbankTextBox";
            this.perbankTextBox.ReadOnly = true;
            this.perbankTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.perbankTextBox.Size = new System.Drawing.Size(876, 331);
            this.perbankTextBox.TabIndex = 0;
            // 
            // corporbankPage
            // 
            this.corporbankPage.Controls.Add(this.corporTextBox);
            this.corporbankPage.Location = new System.Drawing.Point(4, 22);
            this.corporbankPage.Name = "corporbankPage";
            this.corporbankPage.Padding = new System.Windows.Forms.Padding(3);
            this.corporbankPage.Size = new System.Drawing.Size(876, 331);
            this.corporbankPage.TabIndex = 1;
            this.corporbankPage.Text = "企业网银日志";
            this.corporbankPage.UseVisualStyleBackColor = true;
            this.corporbankPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // corporTextBox
            // 
            this.corporTextBox.Location = new System.Drawing.Point(0, 0);
            this.corporTextBox.Multiline = true;
            this.corporTextBox.Name = "corporTextBox";
            this.corporTextBox.ReadOnly = true;
            this.corporTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.corporTextBox.Size = new System.Drawing.Size(876, 331);
            this.corporTextBox.TabIndex = 0;
            // 
            // innermanagePage
            // 
            this.innermanagePage.Controls.Add(this.innermanageTextBox);
            this.innermanagePage.Location = new System.Drawing.Point(4, 22);
            this.innermanagePage.Name = "innermanagePage";
            this.innermanagePage.Padding = new System.Windows.Forms.Padding(3);
            this.innermanagePage.Size = new System.Drawing.Size(876, 331);
            this.innermanagePage.TabIndex = 0;
            this.innermanagePage.Text = "内管日志";
            this.innermanagePage.UseVisualStyleBackColor = true;
            // 
            // innermanageTextBox
            // 
            this.innermanageTextBox.Location = new System.Drawing.Point(0, 0);
            this.innermanageTextBox.Multiline = true;
            this.innermanageTextBox.Name = "innermanageTextBox";
            this.innermanageTextBox.ReadOnly = true;
            this.innermanageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.innermanageTextBox.Size = new System.Drawing.Size(876, 331);
            this.innermanageTextBox.TabIndex = 0;
            // 
            // serviceControllerPage
            // 
            this.serviceControllerPage.Controls.Add(this.serviceControllerTextBox);
            this.serviceControllerPage.Location = new System.Drawing.Point(4, 22);
            this.serviceControllerPage.Name = "serviceControllerPage";
            this.serviceControllerPage.Padding = new System.Windows.Forms.Padding(3);
            this.serviceControllerPage.Size = new System.Drawing.Size(876, 331);
            this.serviceControllerPage.TabIndex = 1;
            this.serviceControllerPage.Text = "serviceController日志";
            this.serviceControllerPage.UseVisualStyleBackColor = true;
            // 
            // serviceControllerTextBox
            // 
            this.serviceControllerTextBox.Location = new System.Drawing.Point(0, 0);
            this.serviceControllerTextBox.Multiline = true;
            this.serviceControllerTextBox.Name = "serviceControllerTextBox";
            this.serviceControllerTextBox.ReadOnly = true;
            this.serviceControllerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serviceControllerTextBox.Size = new System.Drawing.Size(876, 331);
            this.serviceControllerTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.DoubleClick += new System.EventHandler(this.Lable_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "网银运营系统监视工具 V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.perbankPage.ResumeLayout(false);
            this.perbankPage.PerformLayout();
            this.corporbankPage.ResumeLayout(false);
            this.corporbankPage.PerformLayout();
            this.innermanagePage.ResumeLayout(false);
            this.innermanagePage.PerformLayout();
            this.serviceControllerPage.ResumeLayout(false);
            this.serviceControllerPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage perbankPage;
        private System.Windows.Forms.TabPage corporbankPage;
        private System.Windows.Forms.TabPage serviceControllerPage;
        private System.Windows.Forms.TabPage innermanagePage;
        private System.Windows.Forms.TextBox perbankTextBox;
        private System.Windows.Forms.TextBox corporTextBox;
        private System.Windows.Forms.TextBox innermanageTextBox;
        private System.Windows.Forms.TextBox serviceControllerTextBox;
        private System.Windows.Forms.Label label1;
    }
}

