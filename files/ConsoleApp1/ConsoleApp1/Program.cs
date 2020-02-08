using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            appendtext();
                filelocation();

        }

        private static void appendtext()
        {
            string path = @"D:\c#\hello.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("enter some text");
                string text = Console.ReadLine();
                sw.WriteLine("after append" + text);

            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey();
        }

        private static void filelocation()
        {
            string path = @"D:\c#\hello.txt";
            if (!File.Exists(path))
            {
                //create a file to ewrite to
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
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
