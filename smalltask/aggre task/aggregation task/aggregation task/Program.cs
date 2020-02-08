using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c = new Category(2, "it is category");
            Product p = new Product(1,"lappy",500000,c);
                p.display();
        }
    }
}
