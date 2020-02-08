using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Person
        {


            static void Main(string[] args)
            {

                string[] array1 = new string[] { "prasad", "bhosetti" };
                Console.WriteLine(string.Concat(array1));

                string[] array2 = new string[] { "prasad", "leela", "vara" };
                string fullname = string.Join("", array2);
                Console.WriteLine(fullname);

                string s2 = "bhosetti leela vara prasad";
                string[] words = s2.Split();
                foreach (string s in words)
                {
                    Console.WriteLine(s);
                }

            }



        }
    }
    
}
