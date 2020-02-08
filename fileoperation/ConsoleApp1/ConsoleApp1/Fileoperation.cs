using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Fileoperation
    {
        string path = @"D:\c#\Fileoperation.txt";

       

        public void Createfile(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();

                    Console.WriteLine("enter city");
                    string city = Console.ReadLine();

                    Console.WriteLine("emter id");
                    string id = Console.ReadLine();

                    sw.WriteLine("name " + name);
                    sw.WriteLine("city " + city);
                    sw.WriteLine("id " + id);
                }
            }
        }

            public void Display(string path)
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Console.WriteLine("details are");
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }

                }
            }
            public void Addtofiles(string path)
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    Console.WriteLine("enter text to add");
                    string s = Console.ReadLine();
                    sw.WriteLine(" " + s);

                }
            }
            public void Deletefile(string path)
            {
            File.Delete(path);
            Console.WriteLine("file isdeleted");
            }

        }
    
}
