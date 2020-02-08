using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 i;
            i = new rectangle();
            i.draw();
            i = new circle();
            i.draw();
        }
    }
}
