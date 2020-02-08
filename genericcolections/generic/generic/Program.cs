using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course {
                Cid = 1,
                Cname = "java",
                Cfee = 1000,
                Cdate = DateTime.Today
            };

            List<Course> courselist = new List<Course>();
            courselist.Add(c);
            courselist.Add(new Course
            { 
                    Cid = 2,
                    Cname = "c",
                    Cfee = 2000,
                    Cdate = Convert.ToDateTime("9-8-1234")}
             );

            courselist.Add(new Course
            {
                Cid = 3,
                Cname = "c++",
                Cfee = 3000,
                Cdate = Convert.ToDateTime("8-3-1996") }
            );
            foreach(Course cr in courselist)
            {
                Console.WriteLine("cid:{0}\n cname:{1}\n cfee:{2}\n cdate:{3}", cr.Cid, cr.Cname, cr.Cfee, cr.Cdate);
            }




        }
    }
}
