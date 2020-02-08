using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smalltask
{
    class exam
    {
        //variable
        int smarks;
        float credits;
        string name;
        int id;
        //method
        
       public void pratical(int smarks, float scredits, string sname, int id)
        {
            this.smarks = smarks;
            credits = scredits;
            name = sname;
            this.id = id;

        }
        public void showdata()
        {
            Console.WriteLine(smarks);
            Console.WriteLine(credits);
            Console.WriteLine(name);
            Console.WriteLine(id);
        }
           
    }
}
