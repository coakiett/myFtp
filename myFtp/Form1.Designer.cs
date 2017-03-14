namespace myFtp
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoacal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxPowerInfo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxCardResp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLocalPathCard = new System.Windows.Forms.TextBox();
            this.buttonCommitCardFile = new System.Windows.Forms.Button();
            this.buttonSelectPathCard = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "下载";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "目标文件名";
            // 
            // textBoxLoacal
            // 
            this.textBoxLoacal.Location = new System.Drawing.Point(175, 16);
            this.textBoxLoacal.Name = "textBoxLoacal";
            this.textBoxLoacal.Size = new System.Drawing.Size(305, 21);
            this.textBoxLoacal.TabIndex = 1;
            this.textBoxLoacal.Text = "D:\\";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "本地路径";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 228);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxPowerInfo);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBoxLoacal);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "电费柜面文件下载";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxPowerInfo
            // 
            this.textBoxPowerInfo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPowerInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPowerInfo.Location = new System.Drawing.Point(106, 94);
            this.textBoxPowerInfo.Multiline = true;
            this.textBoxPowerInfo.Name = "textBoxPowerInfo";
            this.textBoxPowerInfo.ReadOnly = true;
            this.textBoxPowerInfo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxPowerInfo.Size = new System.Drawing.Size(470, 102);
            this.textBoxPowerInfo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxCardResp);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxLocalPathCard);
            this.tabPage2.Controls.Add(this.buttonCommitCardFile);
            this.tabPage2.Controls.Add(this.buttonSelectPathCard);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "两卡数据上传";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxCardResp
            // 
            this.textBoxCardResp.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCardResp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCardResp.Location = new System.Drawing.Point(57, 82);
            this.textBoxCardResp.Multiline = true;
            this.textBoxCardResp.Name = "textBoxCardResp";
            this.textBoxCardResp.ReadOnly = true;
            this.textBoxCardResp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxCardResp.Size = new System.Drawing.Size(584, 114);
            this.textBoxCardResp.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "文件名称";
            // 
            // textBoxLocalPathCard
            // 
            this.textBoxLocalPathCard.Location = new System.Drawing.Point(114, 38);
            this.textBoxLocalPathCard.Name = "textBoxLocalPathCard";
            this.textBoxLocalPathCard.Size = new System.Drawing.Size(365, 21);
            this.textBoxLocalPathCard.TabIndex = 1;
            // 
            // buttonCommitCardFile
            // 
            this.buttonCommitCardFile.Location = new System.Drawing.Point(566, 38);
            this.buttonCommitCardFile.Name = "buttonCommitCardFile";
            this.buttonCommitCardFile.Size = new System.Drawing.Size(75, 23);
            this.buttonCommitCardFile.TabIndex = 0;
            this.buttonCommitCardFile.Text = "上传";
            this.buttonCommitCardFile.UseVisualStyleBackColor = true;
            this.buttonCommitCardFile.Click += new System.EventHandler(this.buttonCommitCardFile_Click);
            // 
            // buttonSelectPathCard
            // 
            this.buttonSelectPathCard.Location = new System.Drawing.Point(485, 38);
            this.buttonSelectPathCard.Name = "buttonSelectPathCard";
            this.buttonSelectPathCard.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPathCard.TabIndex = 0;
            this.buttonSelectPathCard.Text = "选择";
            this.buttonSelectPathCard.UseVisualStyleBackColor = true;
            this.buttonSelectPathCard.Click += new System.EventHandler(this.buttonSelectPathCard_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 303);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "外围业务数据传输工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoacal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxCardResp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLocalPathCard;
        private System.Windows.Forms.Button buttonCommitCardFile;
        private System.Windows.Forms.Button buttonSelectPathCard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxPowerInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

