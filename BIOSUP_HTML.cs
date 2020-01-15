using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace BiosupCS
{
    public class BIOSUP_HTML
    {
        readonly String str_query = "https://duckduckgo.com/html/?q=";
        readonly String str_ddg_remove = "/l/?kh=-1&amp;uddg=";
        readonly String str_ddg_add = " bios, uefi, support";
        public List<String> list_vendor_check;
        //grab the firsld from the database for vendors and add to array for checking

        public void get_webpage_ddg(String sku)
        {
            get_webpage(this.str_query + sku+ this.str_ddg_add);
        }
        private string clean_url(String url)
        {
            String result = url.Replace("%3A",":");
            result = result.Replace("%2F", "/");
            result = result.Replace("%2D", "-");
            result = result.Replace("%5D", "_");
            result = result.Replace("%2C", ",");
            result = result.Replace("%3D", "=");
            result = result.Replace("%25", "%");

            return result;
        }
        private void get_webpage_model_support(String URL)
        {
            get_webpage(URL);
        }
        private void get_webpage(string str_url)
        {
            this.list_vendor_check = new List<string>();
            this.list_vendor_check.Clear();
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(str_url);
            List<String> list_found_url = new List<String>();

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                String str_check = clean_url(link.Attributes["href"].Value.Replace(this.str_ddg_remove, ""));
                try
                {
                    if (!list_found_url.Contains(str_check))
                    {
                        list_found_url.Add(str_check);
                    }
                    list_found_url = this.list_vendor_check;
                }
                catch
                {
                    this.list_vendor_check.Add("");
                }


            }
            foreach(String link in list_found_url)
            {
                Console.WriteLine(link);
            }



        }
        /*private void get_webpage(string str_url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(str_url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            Webpage_html = s;
            data.Close();
            reader.Close();
        }*/
        public string Webpage_html
        {
            get;set;
        }
        
    }
}
