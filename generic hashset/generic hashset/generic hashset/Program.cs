using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_hashset
{
    class Program
    {
        static void Main(string[] args)
        {
            // Genericqueue();

            // Genericstack();
            // Genericdict();

            sorteddictionary();

        }

        private static void sorteddictionary()
        {
            SortedDictionary<int, Course> sortdt = new SortedDictionary<int, Course>();
            {
                Course c = new Course
                {
                    Cid = 4,
                    Cname = "java",
                    Cfee = 1000,
                    Cdate = DateTime.Today
                };
                Course c1 = new Course
                {
                    Cid = 3,
                    Cname = "angular j",
                    Cfee = 3000,
                    Cdate = DateTime.Today
                };
                sortdt.Add(1, c);
                sortdt.Add(2, c1);
                foreach (KeyValuePair<int, Course> sd in sortdt)
                {
                    Console.WriteLine("cid:{0}\n cname:{1}\n cfee:{2}\n cdate:{3}", sd.Key, sd.Value.Cid, sd.Value.Cname, sd.Value.Cfee, sd.Value.Cdate);

                }
            }
        }

















        private static void Genericstack()

        {
            Console.WriteLine("stack things");
            Console.WriteLine();
            Course c = new Course
            {
                Cid = 4,
                Cname = "java",
                Cfee = 1000,
                Cdate = DateTime.Today
            };
            Stack<Course> s = new Stack<Course>();
            s.Push(c);
            s.Push(new Course
            {
                Cid = 5,
                Cname = "ae",
                Cfee = 2000,
                Cdate = Convert.ToDateTime("9-6-1233")

            }
             );


            s.Push(new Course
            {
                Cid = 6,
                Cname = "bank coaching",
                Cfee = 3000,
                Cdate = Convert.ToDateTime("8-3-1996")
            }
            );
            Console.WriteLine();
            foreach (Course cr in s)
            {
                Console.WriteLine("cid:{0}\n cname:{1}\n cfee:{2}\n cdate:{3}", cr.Cid, cr.Cname, cr.Cfee, cr.Cdate);
            }

        }
        

        private static void Genericqueue()
        {
            Console.WriteLine("queue things");
            Console.WriteLine();
            Course c = new Course
            {
                Cid = 1,
                Cname = "java",
                Cfee = 1000,
                Cdate = DateTime.Today
            };

            Queue<Course> q = new Queue<Course>();
            q.Enqueue(c);
            q.Enqueue(new Course
            {
                Cid = 2,
                Cname = "c",
                Cfee = 2000,
                Cdate = Convert.ToDateTime("9-8-1234")

            }
             );


            q.Enqueue(new Course
            {
                Cid = 3,
                Cname = "c++",
                Cfee = 3000,
                Cdate = Convert.ToDateTime("8-3-1996")
            }
            );
            foreach (Course cr in q)
            {
                Console.WriteLine("cid:{0}\n cname:{1}\n cfee:{2}\n cdate:{3}", cr.Cid, cr.Cname, cr.Cfee, cr.Cdate);
            }
           

        }

        private static void Genericdict()
        {
            Dictionary<int, Course> dc = new Dictionary<int, Course>();
            dc.Add(1, new Course
            {
                Cid = 4,
                Cname = "java",
                Cfee = 1000,
                Cdate = DateTime.Today
            });
            foreach (KeyValuePair<int, Course> d in dc)
            {
                Console.WriteLine("cid:{0}\n cname:{1}\n cfee:{2}\n cdate:{3}\n {4}", d.Key, d.Value.Cid,
                    d.Value.Cname, d.Value.Cfee, d.Value.Cdate);
            }
        }

    }
    
}
