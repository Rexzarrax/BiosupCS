using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BiosupCS
{
    class BIOSUP_CONFIG
    {
        readonly String str_conf_location;
        public List<String> List_intel_chipsets;
        public List<String> List_amd_chipsets;
        public List<String> List_vendors;
        public String Str_option;

        public BIOSUP_CONFIG(String str_working_dir)
        {
            this.str_conf_location = str_working_dir+"last_config.conf";
        }

        private List<String> insert_values(String Line)
        {
            List<String> list = new List<String>();
            foreach(String str_index in Line.Split(','))
            {
                list.Add(str_index);
            }
            return list;
            
        }

        public void load_config()
        {
            try
            {
                string[] lines = File.ReadAllLines(str_conf_location);

                List_intel_chipsets = insert_values(lines[1]);
                List_amd_chipsets = insert_values(lines[0]);
                List_vendors = insert_values(lines[2]);

                Str_option = lines[3];
            }
            catch
            {
                MessageBox.Show("Could not load Config file", "Error");
            }

        }

        public void set_config(List<List<String>> list_of_lists, int drop_down_value)
        {
            if (!File.Exists(str_conf_location))
            {
                File.CreateText(str_conf_location);
            }

            FileInfo FI_config = new FileInfo(str_conf_location);
            int i = 0;

            while (IsFileLocked(FI_config))
            {
                Thread.Sleep(200);
                Console.WriteLine("{" + i + "} Waiting for File Unlock...");
                if (i == 50)
                {
                    Console.WriteLine("File Unlock Failed...");
                    return;
                }
                i++;
            }

            Console.WriteLine("Begining Writing...");

            i = 0;
            foreach (List<String> list in list_of_lists)
            {
                String str_to_write = string.Join(",", list.ToArray());
                str_to_write += "\n";

                if (i == 0)
                {
                    File.WriteAllText(str_conf_location, str_to_write);
                }
                else
                {
                    File.AppendAllText(str_conf_location, str_to_write);
                }
                i++;
            }
            File.AppendAllText(str_conf_location, drop_down_value.ToString());
            Console.WriteLine("Writing Finished...");

        }
        protected virtual bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException e)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                Console.WriteLine(e.Message);
                return true;
            }

            //file is not locked
            return false;
        }
    }
}
