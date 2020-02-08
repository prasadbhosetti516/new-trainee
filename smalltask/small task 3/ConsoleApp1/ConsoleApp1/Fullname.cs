using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fullname
    {
      public  void method2(string fname,string lname)
        {
            string[] names = { "parents", " are" };
            string ss=string.Concat(",",names);
            Console.WriteLine("Fullname is",ss);
        }
    }
}
