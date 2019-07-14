namespace Chinook.CompositeControls
{
    partial class CheckableComboBox
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
            this.chbArtistId = new System.Windows.Forms.CheckBox();
            this.cbbArtistId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chbArtistId
            // 
            this.chbArtistId.AutoSize = true;
            this.chbArtistId.Location = new System.Drawing.Point(3, 3);
            this.chbArtistId.Name = "chbArtistId";
            this.chbArtistId.Size = new System.Drawing.Size(15, 14);
            this.chbArtistId.TabIndex = 6;
            this.chbArtistId.UseVisualStyleBackColor = true;
            this.chbArtistId.CheckedChanged += new System.EventHandler(this.ChbArtistId_CheckedChanged);
            // 
            // cbbArtistId
            // 
            this.cbbArtistId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbArtistId.DisplayMember = "Name";
            this.cbbArtistId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArtistId.Enabled = false;
            this.cbbArtistId.FormattingEnabled = true;
            this.cbbArtistId.Location = new System.Drawing.Point(24, 0);
            this.cbbArtistId.Name = "cbbArtistId";
            this.cbbArtistId.Size = new System.Drawing.Size(159, 20);
            this.cbbArtistId.TabIndex = 5;
            this.cbbArtistId.ValueMember = "ArtistId";
            // 
            // CheckableComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chbArtistId);
            this.Controls.Add(this.cbbArtistId);
            this.Name = "CheckableComboBox";
            this.Size = new System.Drawing.Size(186, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbArtistId;
        private System.Windows.Forms.ComboBox cbbArtistId;
    }
}
