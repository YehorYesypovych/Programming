using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2.Accessories
{
    public class Accessory
    {
        public string Name;
        public double Price;

        public Accessory(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public void Print()
        {
            Console.WriteLine($"{Name}, {Price} грн");
        }

    }
}
