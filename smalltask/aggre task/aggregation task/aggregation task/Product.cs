using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation_task
{
    class Product
    {
        int pid;
        string pname;
        int pprice;
        public Category ctg;
        public Product(int id,string name,int price,Category ctg)
        {
            pid = id;
            pname = name;
            pprice = price;
            this.ctg = ctg;
            
        }
        public void display()
        {
            Console.WriteLine(pid + " " + pname + " " + pprice + " " +
                ctg.cid + " " + ctg.cdesc);
        }

    }
}
