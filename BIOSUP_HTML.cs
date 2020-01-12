using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace BiosupCS
{
    public class BIOSUP_HTML
    {
        readonly String str_query = "https://duckduckgo.com/html/?q=";
        readonly List<String> arr_vendor_check;
        //grab the firsld from the database for vendors and add to array for checking

        public BIOSUP_HTML(List<String>  arr_input_vendor_check)
        {
            arr_vendor_check = arr_input_vendor_check;
        }
        public void get_webpage_ddg(String sku)
        {
            get_webpage(this.str_query + sku);
        }

        private void get_webpage_model_support(String URL)
        {
            get_webpage(URL);
        }

        private void get_webpage(string str_url)
        {
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            Stream data = client.OpenRead(str_url);
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            Console.WriteLine(s);
            data.Close();
            reader.Close();
        }
        
    }
}
