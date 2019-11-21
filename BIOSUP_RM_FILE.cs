using System;
using System.IO;

namespace BIOSUP
{
    public class BIOSUP_RM_FILE {
    public static void main(String str_file_path){
        try{

            if(File.Exists(str_file_path)){
                File.Delete(str_file_path);
                Console.WriteLine("File Deleted: "+str_file_path);
            }else{
                Console.WriteLine("Delete Failed: "+str_file_path);
            }
        }catch(Exception e){
            Console.WriteLine(e);
        }
    }
}
}
