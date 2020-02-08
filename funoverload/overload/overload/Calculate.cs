using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    class Calculate
    {
        public int  area(int side)
        {
            int a = side * side;
            return a;
        }
        public string area(int l, int b)
        {
            int a = l * b;
            return string.Format("rectangle area={0}", a);
        }
        public string area(double r)
        {
            double a = Math.PI * r * r;
            return string.Format("circle area={0}", a);
        }
        public string area(double b,double h)
        {
            double a =0.5f*b*h;
            return string.Format("triangle area={0}", a);
        }
    }
}
