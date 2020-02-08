using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Course
    {
        public int cid
        {
            get;set;
        }
        public string cname
        {
            get; set;
        }
        public int cfee
        {
            get; set;
        }
        public DateTime startDate
        {
            get; set;
        }
        void show()
        {
            Console.WriteLine("id:{0}\n nmae:{1}\n date:{2}", cid, cname, startDate);
        }
    }
}
