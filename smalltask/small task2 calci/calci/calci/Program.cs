using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
          Console.WriteLine("addition is " +c.add());
            Console.WriteLine (c.mul());
            Console.WriteLine( c.sub());
            Console.WriteLine(c.divide());
            Console.ReadKey();
        }
    }
}
