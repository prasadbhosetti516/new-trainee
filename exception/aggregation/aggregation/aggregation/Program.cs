using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Program
    {
        static void Main(string[] args)
        { 
            Employee e = new Employee(12,"prasad","rkpuram");
            Department d = new Department(13, "ddd", e);
            d.display();
            
        }
    }
}
