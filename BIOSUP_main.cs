using System;
using System.IO;

namespace BIOSUP
{
    class BIOSUP_BACKEND {
    public static void main (String[] args){
       Console.WriteLine("Starting Biosup...\n");
       
       String str_working_dir = System.AppDomain.CurrentDomain.BaseDirectory;
       Console.WriteLine("Working Dir: "+ str_working_dir+"\n");

            /*String str_connection_url = "Server=tcp:biosup.database.windows.net,1433;Initial Catalog=firmware-info;Persist Security Info=False;User ID=jaycar-root;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            BIOSUP_SQL.main(str_connection_url);
            */
            String BIOSHERE = str_working_dir+"/BIOSHERE/";
      if(!File.Exists(BIOSHERE)){
            System.IO.Directory.CreateDirectory(BIOSHERE);
      }

      //String str_testfilepath = str_working_dir+"/BIOSHERE/"+phantom4.model+".zip";
      
      //try{
      // BIOSUP_DL_FILE.main(phantom4.dl_url,str_testfilepath);
      // BIOSUP_UNZIP.main(str_testfilepath,str_working_dir+"/BIOSHERE/"+phantom4.model);
      // BIOSUP_RM_FILE.main(str_testfilepath);
     // }
      //(Exception e){
      //    Console.WriteLine(e);
      //}
    
    }

}
    class test_model {
        int id;
        String chipset,model,vendor,dl_url;
        public test_model(int int_id, String str_chipset, String str_model_name, String str_vendor_name,
                String str_dl_url) {
            this.id = int_id;
            this.chipset = str_chipset;
            this.model = str_model_name;
            this.vendor = str_vendor_name;    
            this.dl_url = str_dl_url;
        }
    }
}
/*
What i need:
-Object to handle all things sql
--take in chipset and vendor, return array of url's and other data matching the input
-create folder tree/sort uefi
-check for client updates
-load last config
-basic analytics, successful dl, etc
-logs
-gui
-asus unique(crosshair etc)
--either use table to switch between
-if more then 5 bios fail in similar way, exit
--options:
---select vendor/chipset
---get latest/all/bridge+latest bios(where applicable)
---start
---safe cancel
---run last config
-need to pull gui options on the fly
-Stretch:
--offine mode
---have default/backup copy of db
---host own dl's(intel mainly)
--use treeview for future expandablitiy
*/

/*
*/