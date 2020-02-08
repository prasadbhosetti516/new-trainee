using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(){ "adi", "sri","devika","prasad", };
            foreach (string s in al)
            {
                Console.WriteLine(s);
               
            }
            Console.WriteLine();

            al.Insert(2,"srinu");
            al.Add("louki");
            al.Add("reshu");
           
            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            string[] r = new string[] { "harish", "asma" };
            al.SetRange(5, r);
            Console.WriteLine();
            al.Reverse();

            foreach (string s in al)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Hashtable hst = new Hashtable();
            hst.Add("banda","123");
            hst.Add("pavani", "234");
            hst.Add("vyshu", "345");

            foreach (string k in hst.Keys)
            {
                Console.WriteLine(k);
               
            }
            Console.WriteLine();
            hst.Remove("vyshu");
            Console.WriteLine();
            foreach (string h in hst.Keys)
            {
                Console.WriteLine(h);

            }
            Console.WriteLine();

            foreach (string h in hst.Values)
            {
                Console.WriteLine(h);
                
            }
            Console.WriteLine();
        }
        }
    }

