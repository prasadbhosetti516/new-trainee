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
            Iairborne i;
            i=new Aeroplane();
            i.fly();
            i = new Heloicopter();
            i.fly();
       
           
           
            
        }
    }
}
