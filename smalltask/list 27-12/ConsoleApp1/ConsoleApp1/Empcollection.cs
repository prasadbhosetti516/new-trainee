using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empcollection
    {
        List<Employee> Emp = new List<Employee>();
        public void addmethod()
        {
            Console.WriteLine("enter emp data");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string desg = Console.ReadLine();
            double sal = double.Parse(Console.ReadLine());
            Emp.Add(new Employee
            {
                Eid = id,
                Ename = name,
                Edesg = desg,
                Esal = sal

            }
            );









            /*public void addmethod(int id, string name, string desg, double sal)

                {
                    Emp.Add(new Employee
                    {
                        Eid = id,
                        Ename = name,
                        Edesg = desg,
                        Esal = sal
                    });


                }*/
        }
           public  void Show()
            {
                foreach (Employee ee in Emp)
                {
                    Console.WriteLine("id is:{0}\n name is:{1}\n designation si:{2}\n sal is:{3}", ee.Eid, ee.Ename, ee.Edesg, ee.Esal);
                    Console.WriteLine();
                }
            }

          public   void Remove(int n)
            {
                Emp.RemoveAt(n);
                Console.WriteLine("afterdeleting unwanted data");
                Console.WriteLine();

                foreach (Employee ee in Emp)
                {

                    Console.WriteLine("id is:{0}\n name is:{1}\n designation si:{2}\n sal is:{3}", ee.Eid, ee.Ename, ee.Edesg, ee.Esal);
                    Console.WriteLine();
                }
            
        }
    }
}
    
            
