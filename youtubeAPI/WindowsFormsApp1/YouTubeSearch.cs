using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class YouTubeSearch : Form
    {
        public YouTubeSearch()
        {
            InitializeComponent();

        }

        async void BtnSearch_Click(object sender, EventArgs e)
        {
            YouTubeService youtube = new YouTubeService
                (new BaseClientService.Initializer()
                {
                    ApiKey = "AIzaSyBJpVoVF7_1Akh04zMryFe04_NItZkaFy4",
                    ApplicationName = "YoutubeSearch"
                });

            var request = youtube.Search.List("snippet");
            request.Q = txtSearch.Text;
            request.MaxResults = 25;

            var result = await request.ExecuteAsync();

            foreach (var item in result.Items)
            {
                if (item.Id.Kind == "youtube#video")
                {
                    lsvResult.Items.Add(item.Id.VideoId.ToString(), item.Snippet.Title, 0);
                }
            }
        }

        private void LsvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lsvResult.SelectedItems.Count > 0)
            {
                // YouTube 비디오 Play를 위한 URL 생성 
                string videoId = lsvResult.SelectedItems[0].Name;
                string youtubeUrl = "http://youtube.com/watch?v=" + videoId;

                // 디폴트 브라우져에서 실행
                Process.Start(youtubeUrl);

                
            }
        }
        
        
    }
}
