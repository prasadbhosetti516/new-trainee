using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dele
{
    class Program
    {

        //  public delegate string mydel(int x, int y);
        //  public delegate string mydel(int s);
        public delegate void deleventhandler();
        public static event deleventhandler handler;
        static void Main(string[] args)
        {
            handler += new deleventhandler(square);
            Console.ReadKey();
        }
        static void circle()
            {
            double r = 12.5;
            double ar = Math.PI * r * r;
            Console.WriteLine(ar);
           

        }
        static void square()
        {
            double s= 12;
            double res = s * s;
            Console.WriteLine(res);
        }
           /* mydel delg = new mydel(area);
            Console.WriteLine(delg(20));
            string area(int s)
            {


                return string.Format("area of square is" + (s * s));
            }*/
            /* mydel delg = new mydel(Add);

            delg += new mydel(Sub);
             Console.WriteLine(delg(12, 25));
             delg -= new mydel(Sub);
             Console.WriteLine(delg(20, 50));*/
        }
           /* static string Add(int x, int y)
            {
                int z = x + y;
                return string.Format("{0} + {1} = {2}",x,y,z);
             }
           static string Sub(int x, int y)
           {
            int z = x - y;
            return string.Format("{0} - {1} = {2}",x,y,z);
           }*/
       

    }
    }


