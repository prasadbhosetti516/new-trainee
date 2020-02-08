using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oloading
{
    struct Demo
    {
        int no1, no2;
        public Demo(int a, int b)
        {
            no1 = a;
            no2 = b;
        }
        public void showdata()
        {
            Console.Write(no1 +" "+ no2);
            Console.WriteLine();
        }
        public static Demo operator+(Demo x,Demo y)
            {
            Demo t = new Demo();
            t.no1 = x.no1 + y.no1;
            t.no2 = x.no2 + y.no2;
            return t;
              }
    }
}
