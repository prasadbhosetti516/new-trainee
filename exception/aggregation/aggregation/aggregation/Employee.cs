using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Employee
    {
        public int eid;
        public string ename,addr;

        public Employee(int eid, string ename, string addr)
        {
            this.eid = eid;
            this.ename = ename;
            this.addr = addr;

        }
    }
}
