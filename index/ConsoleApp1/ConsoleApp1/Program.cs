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
            var data = new Generic<string>();
            data[0] = "product details";
            Console.WriteLine(data[0]);


            var datadetails = new Generic<Product>();
            datadetails[0] = new Product
            {
                Pid = 1,
                Pname = "prasad",
                Pprice = 1000,


            };
            Console.WriteLine(+datadetails[0].Pid + "," + datadetails[0].Pname+"," + datadetails[0].Pprice);
            Console.ReadKey();
        }
    }
}
