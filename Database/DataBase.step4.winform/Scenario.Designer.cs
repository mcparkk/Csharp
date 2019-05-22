namespace DataBase.step4.winform
{
    partial class Scenario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRun = new System.Windows.Forms.Button();
            this.albumName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.count);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.resultTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnRun);
            this.groupBox1.Controls.Add(this.albumName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(356, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "앨범재생시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F);
            this.label3.Location = new System.Drawing.Point(253, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "분";
            // 
            // resultTime
            // 
            this.resultTime.Font = new System.Drawing.Font("굴림", 11F);
            this.resultTime.Location = new System.Drawing.Point(149, 123);
            this.resultTime.Name = "resultTime";
            this.resultTime.ReadOnly = true;
            this.resultTime.Size = new System.Drawing.Size(100, 29);
            this.resultTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "총 재생시간 :";
            // 
            // BtnRun
            // 
            this.BtnRun.Font = new System.Drawing.Font("굴림", 10F);
            this.BtnRun.Location = new System.Drawing.Point(245, 92);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 2;
            this.BtnRun.Text = "검색";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // albumName
            // 
            this.albumName.Font = new System.Drawing.Font("굴림", 11F);
            this.albumName.Location = new System.Drawing.Point(149, 57);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(171, 29);
            this.albumName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "앨범명 :";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(149, 181);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(100, 36);
            this.count.TabIndex = 6;
            // 
            // Scenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "Scenario";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Scenario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox resultTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.TextBox albumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox count;
    }
}