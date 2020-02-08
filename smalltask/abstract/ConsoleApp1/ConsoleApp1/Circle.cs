using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle : Shape
    {public double R { get; set; }
        public override double area()
        {
            double result = Math.PI * R * R;
            //Console.WriteLine("area of circle is:{0}", result);
            return result;
        }
        

    }
}
