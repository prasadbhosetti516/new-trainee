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
            List<Course> clst = new List<Course>()
           {
               new Course
               {
                   cid=1,
                   cname="prasad",
                   cfee=1000,
                   startDate=Convert.ToDateTime("06-08-1996")
               },

            new Course
            {
                cid = 2,
                cname = "adi",
                cfee=2000,
                startDate = Convert.ToDateTime("09-08-1972")
            },
            new Course
            {
                cid = 3,
                cname = "sri",
                cfee=3000,
                startDate = Convert.ToDateTime("09-05-1978")
            },

        };
            Console.WriteLine();
            var Query = from t in clst
                        select t;
            foreach( var q in Query)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.cid, q.cname, q.startDate.ToShortDateString(),q.cfee);
            }
            Console.WriteLine();
            var Query1 = from u in clst
                         where u.cid == 2
                       select u;
            foreach (var q in Query1)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.cid, q.cname, q.startDate.ToShortDateString(), q.cfee);
            }
            Console.WriteLine();
            var Query2 = from g in clst
                      orderby g.cname
                       select g;
            foreach (var q in Query2)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.cid, q.cname, q.startDate.ToShortDateString(), q.cfee);
            }
        }
    }
}
