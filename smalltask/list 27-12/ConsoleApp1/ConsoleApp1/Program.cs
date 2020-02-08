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
           
       
        Empcollection ee= new Empcollection();
            Console.WriteLine(" how many members to enter");
            var e = int.Parse(Console.ReadLine());
            for(int i=0;i<e;i++)
            {
                ee.addmethod();
                
            }
            ee.Show();
            Console.WriteLine("enter index");
            int n = int.Parse(Console.ReadLine());
            ee.Remove(n);
           
       
            Console.ReadKey();

          /*  ee.addmethod(1, "prasad", "engineer", 10000.00);
            ee.addmethod(2, "pras", "architect", 450000.00);
            ee.addmethod(3, "pra", "mechanic", 560000.00);
            ee.addmethod(4, "pr", "doctor", 150000.00);
           */
        }
        
    }
}
