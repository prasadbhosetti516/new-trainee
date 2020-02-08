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
            //creating obj for triannee class
            gettrobj();

            gettr1obj();

            Console.ReadKey();

        }

        private static void gettr1obj()
        {
            Traineee tr1 = new Traineee();
            Console.WriteLine();
            tr1.getdata("dfdkhf", "sdgasyd55", "asasas", 45);
            tr1.showdata();
        }

        private static void gettrobj()
        {
            Traineee tr = new Traineee();
            Console.WriteLine();
            tr.getdata("prasad", "16asd", "eluru", 23);
            tr.showdata();
        }
    }
}
