using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount ba = new Bankaccount
            {
                Accountnumber = 123456789,
                Balance = 100000,
                c = new Customer
                {
                    Cid = 12345,
                    Cname = "prasad",
                    Caddress = "chennai"
                }
            };
            Console.WriteLine(ba.c.show());
            Console.WriteLine(ba.show());
            Console.WriteLine(ba.interestamount(ba.Balance));
            Fixedaccount fa = new Fixedaccount();
            Console.WriteLine(fa.interestamount(ba.Balance));
           
        }
    }
}
