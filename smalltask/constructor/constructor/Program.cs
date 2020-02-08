using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car("pondicherry",456,"fff","g");
            car c1 = new car("pondi", 46,"gg");
            car c2= new car("pondi", 46);
            c2.showdata();
            c.showdata();
            c1.showdata();
            Console.WriteLine(c.showdata());

            Console.ReadKey();
        }
    }
}
