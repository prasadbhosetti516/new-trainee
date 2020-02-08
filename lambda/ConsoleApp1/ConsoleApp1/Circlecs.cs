using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class Circlecs
    {
        private double radius;
        string st;
        public double Calculator(Func<double,double> mp)
        {
            return mp(radius);
        }
        public String Upper(Func<string, string> up)
        {
            return up(st);
        }
    }
}
