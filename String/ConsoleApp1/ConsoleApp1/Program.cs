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
            string data = "prasadkanna";
            Console.WriteLine(data);
            string a = data.Insert(6, "loves");
            string bn = "pair looks great";
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a, bn));
            string up = data.ToUpper();
            string lc = data.ToLower();
            Console.WriteLine("substring{0}", bn.Substring(6,7));
            Console.WriteLine("upper:{0} lower:{1}", up, lc);
            string[] names = new string[] { "adi", "sri", "devi", "srinu", "prasad", "reshu", "loukii" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",",names);
            Console.WriteLine(allnames);
            string st1 = "welcome to their presentlife";
            string[] words = st1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);

            }
            string nstr =string.Copy(st1);
            Console.WriteLine("copied string is{0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine("index is{0}", i);
            int l = st1.Length;
            Console.WriteLine("length of string is{0}", l);
            words.Reverse();
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
            int nx=string.Compare("hello","hello");
            Console.WriteLine("comparison is{0}", nx);
            Console.ReadKey();
           
        }
    }
}
