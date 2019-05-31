namespace Chinook.Controls
{
    partial class uscTrackSearchControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkArtistId = new System.Windows.Forms.CheckBox();
            this.chkAlbumId = new System.Windows.Forms.CheckBox();
            this.cbbGenreId = new System.Windows.Forms.ComboBox();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbAlbumId = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTrackName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.chkArtistId);
            this.groupBox1.Controls.Add(this.chkAlbumId);
            this.groupBox1.Controls.Add(this.cbbGenreId);
            this.groupBox1.Controls.Add(this.cbbAlbumId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTrackName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "< 단가 <";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox2.Location = new System.Drawing.Point(647, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Location = new System.Drawing.Point(468, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 6;
            // 
            // chkArtistId
            // 
            this.chkArtistId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkArtistId.AutoSize = true;
            this.chkArtistId.Location = new System.Drawing.Point(286, 29);
            this.chkArtistId.Name = "chkArtistId";
            this.chkArtistId.Size = new System.Drawing.Size(18, 17);
            this.chkArtistId.TabIndex = 5;
            this.chkArtistId.UseVisualStyleBackColor = true;
            this.chkArtistId.CheckedChanged += new System.EventHandler(this.ChkArtistId_CheckedChanged);
            // 
            // chkAlbumId
            // 
            this.chkAlbumId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAlbumId.AutoSize = true;
            this.chkAlbumId.Location = new System.Drawing.Point(123, 27);
            this.chkAlbumId.Name = "chkAlbumId";
            this.chkAlbumId.Size = new System.Drawing.Size(18, 17);
            this.chkAlbumId.TabIndex = 4;
            this.chkAlbumId.UseVisualStyleBackColor = true;
            this.chkAlbumId.CheckedChanged += new System.EventHandler(this.ChkAlbumId_CheckedChanged);
            // 
            // cbbGenreId
            // 
            this.cbbGenreId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbGenreId.DataSource = this.trackBindingSource;
            this.cbbGenreId.DisplayMember = "Genre";
            this.cbbGenreId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenreId.FormattingEnabled = true;
            this.cbbGenreId.Location = new System.Drawing.Point(310, 28);
            this.cbbGenreId.Name = "cbbGenreId";
            this.cbbGenreId.Size = new System.Drawing.Size(121, 23);
            this.cbbGenreId.TabIndex = 3;
            this.cbbGenreId.ValueMember = "GenreId";
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataSource = typeof(Chinook.Data.Track);
            // 
            // cbbAlbumId
            // 
            this.cbbAlbumId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbAlbumId.DataSource = this.trackBindingSource;
            this.cbbAlbumId.DisplayMember = "Album";
            this.cbbAlbumId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlbumId.FormattingEnabled = true;
            this.cbbAlbumId.Location = new System.Drawing.Point(147, 27);
            this.cbbAlbumId.Name = "cbbAlbumId";
            this.cbbAlbumId.Size = new System.Drawing.Size(121, 23);
            this.cbbAlbumId.TabIndex = 2;
            this.cbbAlbumId.ValueMember = "AlbumId";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Location = new System.Drawing.Point(766, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtTrackName
            // 
            this.txtTrackName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTrackName.Location = new System.Drawing.Point(6, 24);
            this.txtTrackName.Name = "txtTrackName";
            this.txtTrackName.Size = new System.Drawing.Size(100, 25);
            this.txtTrackName.TabIndex = 0;
            // 
            // uscTrackSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uscTrackSearchControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(857, 69);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkArtistId;
        private System.Windows.Forms.CheckBox chkAlbumId;
        private System.Windows.Forms.ComboBox cbbGenreId;
        private System.Windows.Forms.ComboBox cbbAlbumId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTrackName;
        private System.Windows.Forms.BindingSource trackBindingSource;
    }
}
