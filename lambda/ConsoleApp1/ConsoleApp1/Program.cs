using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trianglearea();
            mul();
             Squarearea();
            LambdaLinqOrder();
            LambdaLinq();

            Circlecs c = new Circlecs();
            Console.WriteLine("emter radius");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(c.Calculator(r => 2 * Math.PI * p));
            Console.WriteLine();
            Console.WriteLine(c(r => Math.PI * p * p));
            Console.WriteLine(c.Calculator(a => p * p * p));
            Console.WriteLine("emter a string in lowercase");
            Console.WriteLine(Circlecs.Upper(a => string.toUpper());














        }


        private static void Squarearea()
        {
            Func<int, int> area = x => x * x;
            Console.WriteLine(area(12));
        }

        private static void mul()
        {
            Func<int, int, int> mulnumbers = (x, y) => x * 2 + y;
            Console.WriteLine(mulnumbers(10, 10));
        }

        private static void Trianglearea()
        {
            Func<double, double, double> Triangle = (x, y) => 0.5 * x * y;
            Console.WriteLine(Triangle(10, 10));
        }

        public static void LambdaLinqOrder()
        {
            int[] nos = { 45, 23, 12, 98, 65 };
            var sort = nos.OrderBy(x => x);
            
            Console.WriteLine(string.Join(" ", sort));
        }
        public static void LambdaLinq()
        {
            int[] num = { 2,3,4,5,6};
            var Squarenum = num.Select(x=> x*x);

            Console.WriteLine(string.Join(" ", Squarenum));
        }


    }
}
