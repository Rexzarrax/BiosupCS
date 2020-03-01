using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace BiosupCS
{
    public class BIOSUP_HTML
    {
        public List<String> list_url;
        public List<String> list_vendor_dl_found;
        readonly String str_query = "https://duckduckgo.com/html/?q=";
        readonly String str_ddg_remove = "/l/?kh=-1&amp;uddg=";
        readonly String str_ddg_add = " bios, uefi, support";
        readonly List<String> list_vendor_check2;
        readonly List<String> list_vendor_dl_check;
        //grab the firsld from the database for vendors and add to array for checking

        public BIOSUP_HTML(List<String> vendor_check_list, List<String> list_vendor_dl_check)
        {
            this.list_vendor_check2 = vendor_check_list;
            this.list_vendor_dl_check = list_vendor_dl_check;
        }

        public void Get_webpage_ddg(String sku)
        {
            Get_webpage(this.str_query + sku+ this.str_ddg_add, ref this.list_url);

            List<String> list_old = new List<String>(this.list_url);

            foreach(String url in list_old)
            {
                bool result = false;
                foreach (String check in this.list_vendor_check2)
                {
                    string input = url;
                    string pattern = check;

                    Console.WriteLine("Original String: {0}", input);
                    Console.WriteLine("Pattern String: {0}", pattern);

                    Regex rgx = new Regex(pattern,RegexOptions.IgnoreCase);
                    result = rgx.IsMatch(input);
                    Console.WriteLine(result);
                    if (result)
                    {
                        Console.WriteLine("Match!");
                        break;
                    }

                }
                Console.WriteLine(result);
                if (result)
                {
                    Console.WriteLine("Match!");
                    break;
                }
                else
                {
                    this.list_url.Remove(url);

                }

            }

        }

        public void Get_webpage_model_support(String str_url)
        {
            Get_webpage(str_url, ref this.list_vendor_dl_found);

            List<String> list_old = new List<String>(this.list_vendor_dl_found);

            foreach (String url in list_old)
            {
                bool result = false;
                foreach (String check in this.list_vendor_dl_check)
                {
                    string input = url;
                    string pattern = check;

                    Console.WriteLine("Original String: {0}", input);
                    Console.WriteLine("Pattern String: {0}", pattern);

                    Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
                    result = rgx.IsMatch(input);
                    Console.WriteLine(result);
                    if (result)
                    {
                        Console.WriteLine("Match!");
                        break;
                    }

                }
                Console.WriteLine(result);
                if (result)
                {
                    Console.WriteLine("Match!");
                    break;
                }
                else
                {
                    this.list_vendor_dl_found.Remove(url);

                }

            }

        }
        private void Get_webpage(string str_url,ref List<String> list_url)
        {
            list_url = new List<string>();
            list_url.Clear();
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(str_url);
            List<String> list_found_url = new List<String>();

            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                String str_check = Clean_url(link.Attributes["href"].Value.Replace(this.str_ddg_remove, ""));
                try
                {
                    if (!list_found_url.Contains(str_check))
                    {
                       list_found_url.Add(str_check);

                    }
                    list_found_url = list_url;
                }
                catch
                {
                    list_url.Add("");
                }


            }
            foreach(String link in list_found_url)
            {
                Console.WriteLine(link);
            }



        }

        private string Clean_url(String url)
        {
            String result = url.Replace("%3A", ":");
            result = result.Replace("%2F", "/");
            result = result.Replace("%2D", "-");
            result = result.Replace("%5D", "_");
            result = result.Replace("%2C", ",");
            result = result.Replace("%3D", "=");
            result = result.Replace("%25", "%");

            return result;
        }

    }
}
