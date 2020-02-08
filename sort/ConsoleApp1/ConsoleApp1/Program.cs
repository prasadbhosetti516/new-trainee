using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int i;
        static void Main(string[] args)
        {
            
            int[] array = new int[4];
            Console.WriteLine("enter elements into array");
            for(int i=0;i<array.Length;i++)
            {
                
                array[i] =int.Parse( Console.ReadLine());
            }
            void even()
            {
                int Res = array[i] / 2;
                Console.WriteLine("even numbers from array are", res);
            }
           
            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[i]<array[j])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        Console.WriteLine("\n");
                    }
                   foreach(int a in array)
                    {
                        Console.Write(a + " ");
                       
                    }
                   
                }
            }
        }
    }
}
