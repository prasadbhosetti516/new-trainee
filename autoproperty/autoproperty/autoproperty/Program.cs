using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoproperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Timeperiod tp = new Timeperiod();
            tp.hours = 15;
            Console.WriteLine("hours{0}", tp.hours);
            tp.showseconds();
            Console.ReadKey();
        }
    }
}
