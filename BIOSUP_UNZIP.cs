using System;
using System.IO;

namespace BiosupCS
{
    public class BIOSUP_UNZIP
    {
        /*
        * Extract a zip file(str_file_path) to the directory specified(str_destination_folder)(create if it does not exist)
        * 
        *
        */
        public void unzip(String str_zipfile_path, String str_destination_folder)
        {
            /*may not be needed based on upstream code*/
            Console.WriteLine("File to Extract: " + str_zipfile_path);
            Console.WriteLine("File Path of Destination: " + str_destination_folder);

            if (!File.Exists(str_destination_folder))
            {
                System.IO.Directory.CreateDirectory(str_destination_folder);
            }

            //System.IO.Compression.ZipFile.CreateFromDirectory(str_destination_folder, str_zipfile_path);
            System.IO.Compression.ZipFile.ExtractToDirectory(str_zipfile_path, str_destination_folder);
        }
    }
}
