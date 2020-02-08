using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realauto
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pd = new Product { id=1,name="prasad",age=23};
            Console.WriteLine("{0}\n{1}\n{2}" ,pd.id,pd.name,pd.age);
        }
    }
}
