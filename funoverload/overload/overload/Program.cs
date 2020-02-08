using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
           Console.WriteLine( c.area(12));
             Console.WriteLine( c.area(12,23));
            Console.WriteLine( c.area(12.45));
            Console.WriteLine( c.area(12.5656,12.5656));
        }
    }
}
