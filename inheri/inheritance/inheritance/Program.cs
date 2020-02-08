using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle rv = new Vehicle();
           
            rv.show();
           

            Train tr = new Train();
            
            tr.show1();tr.show();

            Ship sp = new Ship();
            sp.show3();sp.show();
            
        }
    }
}
