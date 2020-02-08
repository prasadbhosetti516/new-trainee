using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proprties
{
    class Program
    {
       

     
        public static void Main(string[] args)
        {
            Student std = new Student("leele","prasad");
           // std.Name = "aman";
           std.Idno = 123;
            std.Course = "c#";
           
            std.Joindate = Convert.ToDateTime("01-20-2020");
            Console.WriteLine("name is{0}\n id is{1}", std.Name, std.Idno);
            Console.WriteLine("course is{0}\n  Joiningdate:{1}", std.Course, std.Joindate);
            Console.ReadKey();
        }
    }
}
