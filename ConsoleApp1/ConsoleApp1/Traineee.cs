using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Traineee
    {
        //data fields
        string name, id, addr;//instance variables
        int age;
         public void getdata(string nm,string id,string adr,int age)
        {
            name = nm;
            this.id = id;
            addr = adr;
            this.age = age;
        }
        public void showdata()
        {
            Console.Write(name);
            Console.Write(  id  +  "  "  +  addr  );
            Console.WriteLine(age);
        }
    }
}
