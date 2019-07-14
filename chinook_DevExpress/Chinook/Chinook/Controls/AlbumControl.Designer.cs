namespace Chinook.Controls
{
    partial class AlbumControl
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
            this.components = new System.ComponentModel.Container();
            this.txtAlbumId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbbArtistId = new System.Windows.Forms.ComboBox();
            this.bdsArtist = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlbumId
            // 
            this.txtAlbumId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlbumId.Location = new System.Drawing.Point(72, 3);
            this.txtAlbumId.Name = "txtAlbumId";
            this.txtAlbumId.ReadOnly = true;
            this.txtAlbumId.Size = new System.Drawing.Size(194, 21);
            this.txtAlbumId.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(72, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(194, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // cbbArtistId
            // 
            this.cbbArtistId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbArtistId.DataSource = this.bdsArtist;
            this.cbbArtistId.DisplayMember = "Name";
            this.cbbArtistId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArtistId.FormattingEnabled = true;
            this.cbbArtistId.Location = new System.Drawing.Point(72, 57);
            this.cbbArtistId.Name = "cbbArtistId";
            this.cbbArtistId.Size = new System.Drawing.Size(194, 20);
            this.cbbArtistId.TabIndex = 2;
            this.cbbArtistId.ValueMember = "ArtistId";
            // 
            // bdsArtist
            // 
            this.bdsArtist.DataSource = typeof(Chinook.Data.Artist);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Album ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Artist : ";
            // 
            // AlbumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbArtistId);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAlbumId);
            this.Name = "AlbumControl";
            this.Size = new System.Drawing.Size(269, 171);
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlbumId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbbArtistId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdsArtist;
    }
}
