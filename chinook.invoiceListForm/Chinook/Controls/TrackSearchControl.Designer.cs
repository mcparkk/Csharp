namespace Chinook.Controls
{
    partial class TrackSearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.uscMaxUnitPrice = new Chinook.CompositionControls.ChekableNumericUpDown();
            this.uscAlbum = new Chinook.CompositionControls.CheckableComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uscMinUnitPrice = new Chinook.CompositionControls.ChekableNumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.uscArtist = new Chinook.CompositionControls.CheckableComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.uscMaxUnitPrice);
            this.groupBox1.Controls.Add(this.uscAlbum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.uscMinUnitPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.uscArtist);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(521, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(449, 58);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 18);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // uscMaxUnitPrice
            // 
            this.uscMaxUnitPrice.Location = new System.Drawing.Point(259, 54);
            this.uscMaxUnitPrice.Name = "uscMaxUnitPrice";
            this.uscMaxUnitPrice.Size = new System.Drawing.Size(81, 22);
            this.uscMaxUnitPrice.TabIndex = 19;
            // 
            // uscAlbum
            // 
            this.uscAlbum.Location = new System.Drawing.Point(439, 17);
            this.uscAlbum.Name = "uscAlbum";
            this.uscAlbum.Size = new System.Drawing.Size(74, 22);
            this.uscAlbum.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "최대 단가 : ";
            // 
            // uscMinUnitPrice
            // 
            this.uscMinUnitPrice.Location = new System.Drawing.Point(90, 54);
            this.uscMinUnitPrice.Name = "uscMinUnitPrice";
            this.uscMinUnitPrice.Size = new System.Drawing.Size(81, 22);
            this.uscMinUnitPrice.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "앨범 : ";
            // 
            // uscArtist
            // 
            this.uscArtist.Location = new System.Drawing.Point(255, 17);
            this.uscArtist.Name = "uscArtist";
            this.uscArtist.Size = new System.Drawing.Size(81, 22);
            this.uscArtist.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "최소 단가 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "아티스트 : ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "제목 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 18);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(81, 21);
            this.txtName.TabIndex = 0;
            // 
            // TrackSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TrackSearchControl";
            this.Size = new System.Drawing.Size(521, 88);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private CompositionControls.CheckableComboBox uscAlbum;
        private CompositionControls.CheckableComboBox uscArtist;
        private CompositionControls.ChekableNumericUpDown uscMaxUnitPrice;
        private CompositionControls.ChekableNumericUpDown uscMinUnitPrice;
    }
}
