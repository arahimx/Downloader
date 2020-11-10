using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;

namespace Downloader
{
    public partial class download_form : Form
    {
        public download_form()
        {
            InitializeComponent();
        }

        private void download_form_Load(object sender, EventArgs e)
        {
            Resolution_comboBox.SelectedIndex = 0;
        }

        private void Download_button_Click(object sender, EventArgs e)
        {
            progress_bar.Minimum = 0;
            progress_bar.Maximum = 100;
            IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(Url_textbox.Text);
            VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(Resolution_comboBox.Text));
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }
            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\" + " by arahimx" + video.Title + video.VideoExtension));
            downloader.DownloadProgressChanged += Downloader_DownloadProgressChanged;
            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }

        private void Downloader_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                progress_bar.Value = (int)e.ProgressPercentage;
                Progress_lbl.Text = $"{string.Format("{0:0.##}", e.ProgressPercentage)}%";
                Progress_lbl.Update(); 
            }));
        }
    }

   
}
