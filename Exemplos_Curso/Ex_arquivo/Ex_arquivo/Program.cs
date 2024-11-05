using System;
using System.IO;

namespace Ex_arquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string soucerPath = @"D:\Users\Thiago Araújo\Documents\teste.txt";
            string targetPath = @"D:\Users\Thiago Araújo\Documents\teste3.txt";


            try
            {

                FileInfo fileInfo = new FileInfo(soucerPath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(targetPath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);

            }
             */

            /*
            string path = @"D:\Users\Thiago Araújo\Documents\teste.txt";

            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }



            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }
            */

            /* using
            string path = @"D:\Users\Thiago Araújo\Documents\teste.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }

            */


            /* Pasta
             * string path = @"c:\temp\myfolder";
                try {
                    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                    Console.WriteLine("FOLDERS:");
                    foreach (string s in folders) {
                        Console.WriteLine(s);
                    }
                    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                    Console.WriteLine("FILES:");
                    foreach (string s in files) {
                         Console.WriteLine(s);
                    }
                    Directory.CreateDirectory(@"c:\temp\myfolder\newfolder");
                }
                catch (IOException e) {
                    Console.WriteLine("An error occurred");
                    Console.WriteLine(e.Message);
                }
        
             * 
             */

            /* Path
             * 
             * 
             * string path = @"c:\temp\myfolder\file1.txt";
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
}
             * 
             * 
             * 
             */



        }

    }
}
