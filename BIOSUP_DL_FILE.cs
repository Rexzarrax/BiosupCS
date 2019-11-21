using System;
using System.Net;

namespace BIOSUP
{
    public class BIOSUP_DL_FILE
    {
        public static void main(String str_url, String str_download_to_file)
        {
            Console.WriteLine("Opening connection...");
            Console.WriteLine("UEFI URL: " + str_url);
            Console.WriteLine("Save Path: " + str_download_to_file);
            try
            {
                using (WebClient wc = new WebClient())
                {
                //    wc.DownloadProgressChanged += wc_DownloadProgressChanged();
                    wc.DownloadFileAsync(new System.Uri(str_url), str_download_to_file);
                }
                Console.WriteLine("File Successfully downloaded.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        //void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        //{
        //    progressBar.Value = e.ProgressPercentage;
        //}
    }
}
