using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo(20, 30);
            d1.showdata();
            Demo d2 = new Demo(30, 40);
            d2.showdata();
            Demo s = new Demo();
            s = d1 + d2;
            s.showdata();

        }
    }
}
