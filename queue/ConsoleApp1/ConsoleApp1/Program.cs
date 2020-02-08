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
            Queue qu = new Queue();
            Console.WriteLine("queue operations are");
            qu.Enqueue(123);
            qu.Enqueue(898);
            qu.Enqueue(656);
            foreach(int i in qu)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            qu.Dequeue();
            foreach (int i in qu)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Stack s = new Stack();
            Console.WriteLine("stackoperations are");
            s.Push(12);
            s.Push(13);
            s.Push(14);
            s.Push(15);
            foreach (int j in s)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();
            s.Pop();
            s.Pop();

            foreach (int j in s)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine();

            SortedList sl = new SortedList();
            Console.WriteLine("sorted list operations rae");
            sl.Add("anil",11);
            sl.Add("dp", 2);
            sl.Add("sree", 33);
            foreach (string g in sl.Keys)
            {
                Console.WriteLine(g);
            }
            Console.WriteLine();

            foreach (int h in sl.Values)
            {
                Console.WriteLine(h);
            }
            Console.WriteLine();


        }
    }
}
