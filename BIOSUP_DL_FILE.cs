using System;
using System.ComponentModel;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace BiosupCS
{
    public class BIOSUP_DL_FILE
    {
        readonly ProgressBar progressBar_current_progress;
        public BIOSUP_DL_FILE(ProgressBar progressBar_current_progress)
        {
            this.progressBar_current_progress = progressBar_current_progress;
        }
        public void DL_FILE(String str_url, String str_download_to_file)
        {
            //https://stackoverflow.com/questions/30618452/how-to-implement-a-timeout-on-webclient-downloadfileasync#30618771
            if (Uri.TryCreate(str_url, UriKind.Absolute, out Uri outUri))
            {
                Console.WriteLine("Opening connection...");
                Console.WriteLine("UEFI URL: " + str_url);
                Console.WriteLine("Save Path: " + str_download_to_file);
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Wc_DownloadProgressChanged);
                        wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Wc_DownloadFileCompleted);
                        wc.DownloadFileAsync(new System.Uri(str_url), str_download_to_file);
                    }
                    Console.WriteLine("File Successfully downloaded.");
                    //this.bool_completed = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    //this.bool_completed = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid URL, Please Notify the admin");
            }

        }
        void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar_current_progress.Value = e.ProgressPercentage;
        }
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar_current_progress.Value = 0;
            
            if (e.Cancelled)
            {
                MessageBox.Show("The download has been cancelled");
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                MessageBox.Show("An error ocurred while trying to download file");

                return;
            }
        }
    }
}
