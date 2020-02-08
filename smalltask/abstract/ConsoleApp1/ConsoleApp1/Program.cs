using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program:Circle
    {
        static void Main(string[] args)
        {
            Circle c = new Circle { R = 11 };
           Console.WriteLine( c.area());
            Console.ReadKey();
        }
    }
}
