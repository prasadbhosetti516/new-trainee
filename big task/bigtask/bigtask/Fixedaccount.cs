using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigtask
{
    class Fixedaccount : Bankaccount
    {
        public override string interestamount(double bal)
        {
            Console.WriteLine("enter no of yaers for fixeddeposit");
          //  double rate = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());
            double interest=(bal*6*year)/100;
            double total = interest + bal;
            return total.ToString();
        }
    }
}
