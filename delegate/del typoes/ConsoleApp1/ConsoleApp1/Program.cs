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
            List<Student> lst = new List<Student>
            {
                new Student{Sid=1,Sname="prasad",Scourse="c#",Saddr="vizag"},
                  new Student{Sid=3,Sname="adi",Scourse="R",Saddr="rjy"},
                    new Student{Sid=2,Sname="sri",Scourse="c",Saddr="uk"},
                      new Student{Sid=4,Sname="devi",Scourse="c++",Saddr="bheemili"},
            };
            Console.WriteLine("before sorting");
            foreach (var s in lst)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", s.Sid, s.Sname, s.Scourse, s.Saddr);
            }
            lst.Sort((x,y)=>x.Sid.CompareTo (y.Sid));
            Console.WriteLine("after sorting");
            foreach (var s in lst)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", s.Sid, s.Sname, s.Scourse, s.Saddr);
            }
            /*    Console.WriteLine("after sorting");
             foreach ( var s in lst)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n", s.Sid, s.Sname, s.Scourse, s.Saddr);
            }*/

            Console.WriteLine();
            Func<int, int, double> add = (x, y) => x + y;
            Console.WriteLine("sum is{0}", add(4, 5));

            Console.WriteLine();
            Action<int, int> multiply = (x, y) => Console.WriteLine("{0}", x * y);
            Console.WriteLine("mul is");
             multiply(5, 8);

            Console.WriteLine();
            Predicate<Student> fst = x => x.Sid == 3;
            var st = lst.Find(fst);
            Console.WriteLine("sid {0}\n snamne{1}\n scourse{2}\n s{3}", st.Sid, st.Sname, st.Scourse, st.Saddr);

            Console.ReadKey();
        }
    }
}
