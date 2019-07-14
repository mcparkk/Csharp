namespace Chinook.Forms
{
    partial class AlbumForm2
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
            this.uscAlbum = new Chinook.Controls.AlbumControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uscAlbum);
            this.splitContainer1.Size = new System.Drawing.Size(297, 122);
            this.splitContainer1.SplitterDistance = 88;
            // 
            // uscAlbum
            // 
            this.uscAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAlbum.Location = new System.Drawing.Point(0, 0);
            this.uscAlbum.Name = "uscAlbum";
            this.uscAlbum.Size = new System.Drawing.Size(297, 88);
            this.uscAlbum.TabIndex = 0;
            // 
            // AlbumForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 122);
            this.Name = "AlbumForm2";
            this.Text = "AlbumForm2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AlbumControl uscAlbum;
    }
}