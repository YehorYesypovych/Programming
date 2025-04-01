using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2.Flowers
{
    public class Flower
    {
        public int lengthOfFlower;
        public double Price;
        public int Freshness;
        public string Name;

        public Flower(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
            Random random = new Random();
            lengthOfFlower = random.Next(5, 21);
            Freshness = random.Next(0, 101);

        }
        public void Print()
        {
            Console.WriteLine($"{Name}, {lengthOfFlower} см, {Freshness}%, {Price} грн");
        }

        
    }



}
