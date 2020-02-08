using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class car
    {
        string reg, col, mod;
        int price;
        
        //deafult constructor
        public car()
        {
            Console.WriteLine("default value");
        }
       
        // single parameterised and overloaded
        public car(int price) 
        {
          this.  price = price;
            Console.WriteLine("single value");
        }
       
        //double parameterised
        public car(string registartion,int price)
        {
            reg =registartion ;
            this.price = price;
            Console.WriteLine("2 values displayed");
        }
        
        //three parameterised
        public car(string registartion, int price,string color) 
        {
            reg = registartion;
           this. price = price;
            col = color;
            Console.WriteLine("3 values displayed");
        }
        
        //quad parameterised
        public car(string registartion, int price, string color,string model)
        {
            reg= registartion;
            this.price = price;
            col =color;
            mod = model;
            Console.WriteLine("4 values displayed");
        }
      // public void  showdata()
      public string showdata()
        {
            return string.Format("reg no:{0}\nprice:{1}\ncolor:{2}\nmodel:{3}"
                ,reg, price, col, mod);
            /*Console.WriteLine(reg);
            Console.WriteLine(col);
        
        Console.WriteLine(mod);
        
    Console.WriteLine(price);*/
        }
}

    }

