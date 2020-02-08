using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Exception
    {
      public int  A
        {
            get;
            set;
        }
        public int B
        {
            get;
            set;
        }
        public void div(int a,int b)
        {
            int res;
            A = a;B = b;
            if (b == 0)
                throw new System.Exception("div not possible");
            else
                 res = a / b;
        }

    }
}
