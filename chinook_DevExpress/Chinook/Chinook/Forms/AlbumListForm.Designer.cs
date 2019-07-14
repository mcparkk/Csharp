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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uscSearch = new Chinook.Controls.AlbumSearchControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.uscList = new Chinook.Controls.AlbumListControl();
            this.uscAlbum = new Chinook.Controls.AlbumControl();
            this.bgwWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uscSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(631, 387);
            this.splitContainer1.TabIndex = 0;
            // 
            // uscSearch
            // 
            this.uscSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscSearch.Location = new System.Drawing.Point(0, 0);
            this.uscSearch.Name = "uscSearch";
            this.uscSearch.Size = new System.Drawing.Size(631, 50);
            this.uscSearch.TabIndex = 0;
            this.uscSearch.SearchButtonClicked += new System.EventHandler<Chinook.Controls.AlbumSearchControl.SearchButtonClickedEventArgs>(this.UscSearch_SearchButtonClicked);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.uscList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.uscAlbum);
            this.splitContainer2.Size = new System.Drawing.Size(631, 333);
            this.splitContainer2.SplitterDistance = 409;
            this.splitContainer2.TabIndex = 1;
            // 
            // uscList
            // 
            this.uscList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscList.Location = new System.Drawing.Point(0, 0);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(409, 333);
            this.uscList.TabIndex = 0;
            this.uscList.RowDoubleClicked += new System.EventHandler<Chinook.Controls.AlbumListControl.RowDoubleClickedEventArgs>(this.UscList_RowDoubleClicked);
            this.uscList.RowClicked += new System.EventHandler<Chinook.Controls.AlbumListControl.RowClickedEventArgs>(this.UscList_RowClicked);
            // 
            // uscAlbum
            // 
            this.uscAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAlbum.Location = new System.Drawing.Point(0, 0);
            this.uscAlbum.Name = "uscAlbum";
            this.uscAlbum.ReadOnlyMode = true;
            this.uscAlbum.Size = new System.Drawing.Size(218, 333);
            this.uscAlbum.TabIndex = 0;
            // 
            // bgwWorker
            // 
            this.bgwWorker.WorkerReportsProgress = true;
            this.bgwWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwWorker_DoWorkAsync);
            this.bgwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwWorker_ProgressChanged);
            this.bgwWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwWorker_RunWorkerCompleted);
            // 
            // AlbumListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 397);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlbumListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AlbumListForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.AlbumSearchControl uscSearch;
        private Controls.AlbumListControl uscList;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.AlbumControl uscAlbum;
        private System.ComponentModel.BackgroundWorker bgwWorker;
    }
}