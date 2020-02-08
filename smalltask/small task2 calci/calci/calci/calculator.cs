using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calci
{
    class Calculator
    {
        int a,b;
        public  Calculator()
        {
            Console.WriteLine("default constructor");
        }
        public  Calculator(int a,int b )
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("parameterised constructor");
        }

       public int add()
        {
            return a + b;
        }

       public float sub()
        {
            return a - b;
        }

       public int mul()
        {
            return a * b;
        }

       public double divide()
        {
            return a / b;
        }
    }
}
