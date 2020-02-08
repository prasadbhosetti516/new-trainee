using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public int Sid
        {
            get;set;
        }
        public string Sname
        {
            get; set;
        }
        public string Scourse
        {
            get; set;
        }
        public string Saddr
        {
            get; set;
        }
        public void show()
            {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", Sid, Sname, Scourse, Saddr);
        }
    }
}
