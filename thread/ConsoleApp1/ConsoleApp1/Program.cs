using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ThreadStart tsd = new ThreadStart(getnumbers);
            ThreadStart tsd1 = new ThreadStart(getevennumbers);
            
             Thread th = new Thread(tsd);
            Thread th1 = new Thread(tsd1);
           
             th.Start();
            th1.Start();
         
            Console.ReadKey();
        }
        public static void getnumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "\t");
                Thread.Sleep(500);
            }
        }
        public static void getevennumbers()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + "\t");
                Thread.Sleep(500);
            }

        }
      


        
    }  
}
