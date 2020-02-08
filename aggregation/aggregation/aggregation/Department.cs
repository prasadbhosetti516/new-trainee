using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Department
    {
       public  int did;
        public string dname;
        public Employee employee;
        public Department(int did,string dname,Employee employee)
        {
            this.did = did;
            this.dname = dname;
            this.employee = employee;
        }
        public void display()
        {
            Console.WriteLine(did + " " + dname + " " + employee.eid + " " + employee
                .ename + " " + employee.addr);
        }
    }
}
