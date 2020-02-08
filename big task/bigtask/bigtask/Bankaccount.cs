using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigtask
{
    class Bankaccount
    {
       public int Accountnumber
        {
            get; set;
        }
       public double Balance
        {
            get; set;
        }
        public Customer c
            {
            get;set;
             }
        public string show()
            {
           return string.Format("accountnum:{0}\nbalance:{1}", Accountnumber, Balance);
        }
        public virtual string interestamount(double bal)
        {
            Console.WriteLine("enter rate and yaers");
            double rate = double.Parse(Console.ReadLine());
            double year = double.Parse(Console.ReadLine());
            double intrst = (bal * rate * year) / 100;
            Console.WriteLine(Accountnumber + " " + Balance + " " + c.Cid + " " + c.Cname + " " + c.Caddress);
            return intrst.ToString();
        }
       
    }

}
