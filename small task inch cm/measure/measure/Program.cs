using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace measure
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale s = new Scale();
            Console.WriteLine("input valuev in inches");
            inch = int.Parse(Console.ReadLine());
            s.conversion();
            s.conversion1();
            Console.ReadKey();
        }
    }
}
