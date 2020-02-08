using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Interface1
    {
        void draw();
        
    }
    public class rectangle:Interface1
       
    {
        public void draw()
        {
            Console.WriteLine("draw rect");
        }
    }
    public class circle : Interface1

    {
        public void draw()
        {
            Console.WriteLine("draw circle");
        }
    }


}
