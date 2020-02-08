using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskinterface
{
    class BikeDrone:Bike,Idrone
    {
       public void  Imodel()
        {
            Console.WriteLine("drone is ultra new stylish one");
        }
      public void Idrone2()
        {
            Console.WriteLine("it is old one");
        }
    }
}
