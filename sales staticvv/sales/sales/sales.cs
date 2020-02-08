using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales
{
    class sales
    {
        string productname;
        int quantity; 
        int price;
        public static double totalsales=0;
        public static void add(int a,int b)
        {
            Console.WriteLine("enter num");
            Console.ReadLine();
            for (int i = 0; i < 5; i++){
                Console.WriteLine("ggggg");

            }
        }
        public void share (string pname,int quan,int price)
            {
            productname = pname;
            quantity = quan;
            this.price = price;
            }
        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        public int Quantity
        {
            get { return quantity;}
            set { quantity = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public double salesamount
        {
            get{ return price * quantity; }
        }
        public double totalamount
        {
            get { return totalsales+= salesamount; }
        }
    }
}
