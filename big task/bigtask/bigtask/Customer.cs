using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigtask
{
    class Customer:Bankaccount
    {
       public int Cid
        {
            get;set;
        }
       public string Cname
        {
            get; set;
        }
        public string Caddress
        {
            get;set;
        }
      public string show()
        {
            return string.Format("custid:{0}\ncustname:{1}\ncustaddr:{2}\n",Cid,Cname,Caddress);
        }
    }
}
