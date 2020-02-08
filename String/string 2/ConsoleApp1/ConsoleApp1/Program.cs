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
            StringBuilder std=new StringBuilder("hello");
            Console.WriteLine(std);
            std.Append(23455);
            Console.WriteLine("appens long values{0}", std);
            int i = std.Capacity;
            Console.WriteLine("initial capacity of string builder is {0}", i);
            std.Insert(6, " world");
            Console.WriteLine("inserted at 6 is{ }", std);
            std.Remove(7, 4);
            Console.WriteLine("after removing{0}", std);
            std.Replace("lo", "arious");
            Console.WriteLine("after replacing{0}", std);
        }
    }
}
