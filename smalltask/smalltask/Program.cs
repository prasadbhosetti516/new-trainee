using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smalltask
{
    class Program
    {
        static void Main(string[] args)
        {
            exam e = new exam();
            exam e1 = new exam();
            e.pratical(100,2.5f,"prasad",45);
            e.showdata();
            Console.WriteLine();
            e1.pratical(210, 44.77f, "hasgahsg", 55);
           
            e1.showdata();
            Console.ReadKey();
        }
    }
}
