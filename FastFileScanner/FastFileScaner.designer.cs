
namespace FastFileScanner
{
    partial class FastFileScaner
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastFileScaner));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelExcel = new System.Windows.Forms.LinkLabel();
            this.chkMD5 = new System.Windows.Forms.CheckBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnmd5Scan = new System.Windows.Forms.Button();
            this.btnMd5File = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnScanFile = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.chkExcel = new System.Windows.Forms.CheckBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridFile = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "待扫描的文件夹";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabelExcel);
            this.panel1.Controls.Add(this.chkMD5);
            this.panel1.Controls.Add(this.chkShow);
            this.panel1.Controls.Add(this.btnMD5);
            this.panel1.Controls.Add(this.btnmd5Scan);
            this.panel1.Controls.Add(this.btnMd5File);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnScanFile);
            this.panel1.Controls.Add(this.btnScan);
            this.panel1.Controls.Add(this.chkExcel);
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 117);
            this.panel1.TabIndex = 1;
            // 
            // linkLabelExcel
            // 
            this.linkLabelExcel.AutoSize = true;
            this.linkLabelExcel.Location = new System.Drawing.Point(145, 54);
            this.linkLabelExcel.Name = "linkLabelExcel";
            this.linkLabelExcel.Size = new System.Drawing.Size(89, 12);
            this.linkLabelExcel.TabIndex = 12;
            this.linkLabelExcel.TabStop = true;
            this.linkLabelExcel.Text = "linkLabelExcel";
            this.linkLabelExcel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chkMD5
            // 
            this.chkMD5.AutoSize = true;
            this.chkMD5.Location = new System.Drawing.Point(844, 22);
            this.chkMD5.Name = "chkMD5";
            this.chkMD5.Size = new System.Drawing.Size(114, 16);
            this.chkMD5.TabIndex = 11;
            this.chkMD5.Text = "计算每个文件MD5";
            this.chkMD5.UseVisualStyleBackColor = true;
            // 
            // chkShow
            // 
            this.chkShow.AutoSize = true;
            this.chkShow.Location = new System.Drawing.Point(964, 22);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(96, 16);
            this.chkShow.TabIndex = 10;
            this.chkShow.Text = "显示扫描结果";
            this.chkShow.UseVisualStyleBackColor = true;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(763, 82);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(75, 23);
            this.btnMD5.TabIndex = 9;
            this.btnMD5.Text = "MD5";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnmd5Scan
            // 
            this.btnmd5Scan.Location = new System.Drawing.Point(724, 82);
            this.btnmd5Scan.Name = "btnmd5Scan";
            this.btnmd5Scan.Size = new System.Drawing.Size(33, 23);
            this.btnmd5Scan.TabIndex = 8;
            this.btnmd5Scan.Text = "...";
            this.btnmd5Scan.UseVisualStyleBackColor = true;
            this.btnmd5Scan.Click += new System.EventHandler(this.btnmd5Scan_Click);
            // 
            // btnMd5File
            // 
            this.btnMd5File.Location = new System.Drawing.Point(145, 82);
            this.btnMd5File.Name = "btnMd5File";
            this.btnMd5File.Size = new System.Drawing.Size(572, 21);
            this.btnMd5File.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "请选择计算MD5的文件";
            // 
            // btnScanFile
            // 
            this.btnScanFile.Location = new System.Drawing.Point(763, 17);
            this.btnScanFile.Name = "btnScanFile";
            this.btnScanFile.Size = new System.Drawing.Size(75, 23);
            this.btnScanFile.TabIndex = 4;
            this.btnScanFile.Text = "扫描(&S)";
            this.btnScanFile.UseVisualStyleBackColor = true;
            this.btnScanFile.Click += new System.EventHandler(this.btnScanFile_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(724, 17);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(33, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "...";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // chkExcel
            // 
            this.chkExcel.AutoSize = true;
            this.chkExcel.Checked = true;
            this.chkExcel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcel.Location = new System.Drawing.Point(37, 53);
            this.chkExcel.Name = "chkExcel";
            this.chkExcel.Size = new System.Drawing.Size(102, 16);
            this.chkExcel.TabIndex = 2;
            this.chkExcel.Text = "结果导出Excel";
            this.chkExcel.UseVisualStyleBackColor = true;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(145, 17);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(572, 21);
            this.txtFile.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // dataGridFile
            // 
            this.dataGridFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridFile.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFile.Location = new System.Drawing.Point(0, 117);
            this.dataGridFile.Name = "dataGridFile";
            this.dataGridFile.RowTemplate.Height = 23;
            this.dataGridFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFile.Size = new System.Drawing.Size(1081, 457);
            this.dataGridFile.TabIndex = 3;
            // 
            // FastFileScaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 596);
            this.Controls.Add(this.dataGridFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FastFileScaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件扫描工具";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnScanFile;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.CheckBox chkExcel;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridFile;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnmd5Scan;
        private System.Windows.Forms.TextBox btnMd5File;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.CheckBox chkMD5;
        private System.Windows.Forms.LinkLabel linkLabelExcel;
    }
}

