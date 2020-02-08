using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike b = new Bike();
            b.bikemodel();
            b.bikecolor();
           
            BikeDrone bd = new BikeDrone();
            bd.Imodel();
            Idrone i = bd;
            i.Imodel();
            i.Idrone2();
        }
    }
}
