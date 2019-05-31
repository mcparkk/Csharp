namespace Chinook.Forms
{
    partial class AlbumListForm
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
            this.uscAlbumList = new Chinook.Controls.AlbumListControl();
            this.uscAlbumSearch = new Chinook.Controls.AlbumSearchControl();
            this.SuspendLayout();
            // 
            // uscAlbumList
            // 
            this.uscAlbumList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAlbumList.Location = new System.Drawing.Point(5, 58);
            this.uscAlbumList.Name = "uscAlbumList";
            this.uscAlbumList.Size = new System.Drawing.Size(586, 313);
            this.uscAlbumList.TabIndex = 2;
            // 
            // uscAlbumSearch
            // 
            this.uscAlbumSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.uscAlbumSearch.Location = new System.Drawing.Point(5, 5);
            this.uscAlbumSearch.Name = "uscAlbumSearch";
            this.uscAlbumSearch.Size = new System.Drawing.Size(586, 53);
            this.uscAlbumSearch.TabIndex = 3;
            this.uscAlbumSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.AlbumSearchControl.SearchButtonClickedEventArgs>(this.UscAlbumSearch_SearchButtonClicked);
            // 
            // AlbumListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 376);
            this.Controls.Add(this.uscAlbumList);
            this.Controls.Add(this.uscAlbumSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlbumListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AlbumLIstForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.AlbumListControl uscAlbumList;
        private Controls.AlbumSearchControl uscAlbumSearch;
    }
}