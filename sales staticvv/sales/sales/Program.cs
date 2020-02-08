using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales
{
    class Program
    {
        static void Main(string[] args)
        {
            add(2,3);
            sales s = new sales();
            
  s.Productname = "cake1";
            s.Quantity = 1;
            s.Price = 10;
           
            Console.WriteLine("product{0}\tquantity{1}\tprice{2}\n sales{3}\n total {4}",s.Productname,s.Quantity, s.Price,s.salesamount,s.totalamount);
            Console.WriteLine(s.salesamount);
            Console.WriteLine(s.totalamount);
            sales s1 = new sales();
            s1.Productname = "cake2";
            s1.Quantity = 2;
            s1.Price = 20;

            Console.WriteLine("{0}\t{1}\t{2}\n sales{3}\n total {4}", s1.Productname, s1.Quantity, s1.Price, s1.salesamount, s1.totalamount);
            Console.WriteLine(s.salesamount);
            Console.WriteLine(s.totalamount);
            sales s2 = new sales();
            s2.Productname = "cake3";
            s2.Quantity = 3;
            s2.Price = 30;

            Console.WriteLine("{0}\t{1}\t{2}\n sales{3}\n total {4}", s2.Productname, s2.Quantity, s2.Price, s2.salesamount, s2.totalamount);
            Console.WriteLine(s.salesamount);
            Console.WriteLine(s.totalamount);
        }
    }
}
