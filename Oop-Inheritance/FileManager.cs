using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Inheritance
{
    public static class FileManager
    {
        public static void BulkCopy(string destinationPath, params File[] files)
        {
            if(files is null || files.Length == 0)
            {
                Console.WriteLine("FileManager:: No files to copy!");
                return;
            }

            foreach(var file in files)
            {
                file.Copy(destinationPath);
            }
        }
    }
}
