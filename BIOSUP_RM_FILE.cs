using System;
using System.IO;

namespace BiosupCS
{
    public class BIOSUP_RM_FILE {
        public void Remove(String str_file_path){
            try{
                if(File.Exists(str_file_path)){
                    File.Delete(str_file_path);
                    Console.WriteLine("File Deleted: "+str_file_path);
                }
            }catch(Exception e){
                Console.WriteLine(e);
                Console.WriteLine("Delete Failed: " + str_file_path);
            }
        }
    }
}
