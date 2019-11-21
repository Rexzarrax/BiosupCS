using System;
using System.IO;

namespace BIOSUP
{
    public class BIOSUP_UNZIP
    {
        /*
        * Extract a zip file(str_file_path) to the directory specified(str_destination_folder)(create if it does not exist)
        * 
        *
        */
        public static void main(String str_zipfile_path, String str_destination_folder, String str_start_path)
        {
            /*may not be needed based on upstream code*/
            Console.WriteLine("File to Extract: " + str_zipfile_path);
            Console.WriteLine("File Path of Destination: " + str_destination_folder);

            if (!File.Exists(str_destination_folder))
            {
                System.IO.Directory.CreateDirectory(str_destination_folder);
            }

            System.IO.Compression.ZipFile.CreateFromDirectory(str_start_path, str_zipfile_path);
            System.IO.Compression.ZipFile.ExtractToDirectory(str_zipfile_path, str_destination_folder);
        }
    }
}
