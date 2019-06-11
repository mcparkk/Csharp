namespace Chinook.Controls
{
    partial class TrackListCotrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.bdsTrack = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millisecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ArtistName,
            this.albumIdDataGridViewTextBoxColumn,
            this.mediaTypeIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.composerDataGridViewTextBoxColumn,
            this.millisecondsDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn});
            this.dgvTrack.DataSource = this.bdsTrack;
            this.dgvTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrack.Location = new System.Drawing.Point(0, 0);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowTemplate.Height = 23;
            this.dgvTrack.Size = new System.Drawing.Size(485, 349);
            this.dgvTrack.TabIndex = 4;
            // 
            // bdsTrack
            // 
            this.bdsTrack.DataSource = typeof(Chinook.Data.Track);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ArtistName
            // 
            this.ArtistName.DataPropertyName = "ArtistName";
            this.ArtistName.HeaderText = "Artist";
            this.ArtistName.Name = "ArtistName";
            this.ArtistName.ReadOnly = true;
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumTitle";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            this.albumIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mediaTypeIdDataGridViewTextBoxColumn
            // 
            this.mediaTypeIdDataGridViewTextBoxColumn.DataPropertyName = "MediaTypeName";
            this.mediaTypeIdDataGridViewTextBoxColumn.HeaderText = "Media";
            this.mediaTypeIdDataGridViewTextBoxColumn.Name = "mediaTypeIdDataGridViewTextBoxColumn";
            this.mediaTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreName";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            this.genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // composerDataGridViewTextBoxColumn
            // 
            this.composerDataGridViewTextBoxColumn.DataPropertyName = "Composer";
            this.composerDataGridViewTextBoxColumn.HeaderText = "Composer";
            this.composerDataGridViewTextBoxColumn.Name = "composerDataGridViewTextBoxColumn";
            // 
            // millisecondsDataGridViewTextBoxColumn
            // 
            this.millisecondsDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.millisecondsDataGridViewTextBoxColumn.HeaderText = "Length";
            this.millisecondsDataGridViewTextBoxColumn.Name = "millisecondsDataGridViewTextBoxColumn";
            this.millisecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "C2";
            this.unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // TrackListCotrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTrack);
            this.Name = "TrackListCotrol";
            this.Size = new System.Drawing.Size(485, 349);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.BindingSource bdsTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtistName;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn composerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millisecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
    }
}
