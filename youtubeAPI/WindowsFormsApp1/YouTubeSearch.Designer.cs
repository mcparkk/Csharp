namespace WindowsFormsApp1
{
    partial class YouTubeSearch
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTubeSearch));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lsvResult = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BgwWorker = new System.ComponentModel.BackgroundWorker();
            this.TspProgress = new System.Windows.Forms.ProgressBar();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(21, 32);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lsvResult
            // 
            this.lsvResult.AllowColumnReorder = true;
            this.lsvResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvResult.Location = new System.Drawing.Point(5, 124);
            this.lsvResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvResult.Name = "lsvResult";
            this.lsvResult.ShowItemToolTips = true;
            this.lsvResult.Size = new System.Drawing.Size(544, 443);
            this.lsvResult.SmallImageList = this.imageList1;
            this.lsvResult.TabIndex = 2;
            this.lsvResult.UseCompatibleStateImageBehavior = false;
            this.lsvResult.View = System.Windows.Forms.View.List;
            this.lsvResult.DoubleClick += new System.EventHandler(this.LsvResult_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "puppy-dog.jpg");
            // 
            // BgwWorker
            // 
            this.BgwWorker.WorkerReportsProgress = true;
            this.BgwWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Bgw_ProgressChanged);
            // 
            // TspProgress
            // 
            this.TspProgress.Location = new System.Drawing.Point(21, 70);
            this.TspProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TspProgress.Name = "TspProgress";
            this.TspProgress.Size = new System.Drawing.Size(501, 28);
            this.TspProgress.TabIndex = 3;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(449, 31);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 29);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // YouTubeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 573);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.TspProgress);
            this.Controls.Add(this.lsvResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "YouTubeSearch";
            this.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Text = "YouTubeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lsvResult;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker BgwWorker;
        private System.Windows.Forms.ProgressBar TspProgress;
        private System.Windows.Forms.Button BtnReset;
    }
}

