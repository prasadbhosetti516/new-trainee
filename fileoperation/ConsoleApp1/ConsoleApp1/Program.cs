using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#\Fileoperations.txt";
            Fileoperation fo = new Fileoperation();
            int ch;
            do { 
            Console.WriteLine("enter choice 1.create 2.display 3.append 4.delete");
           
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        fo.Createfile(path);
                        break;
                    case 2:
                        fo.Display(path);
                        break;
                    case 3:
                        fo.Addtofiles(path);
                        break;
                    case 4:
                        fo.Deletefile(path);
                        break;
                    default:
                        Console.WriteLine("wronh choice entered");
                        break;
                }
            } while (ch <= 4);
        }
    }
}
