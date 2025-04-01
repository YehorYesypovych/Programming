using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4._2.Accessories;
using lab4._2.Flowers;

namespace lab4._2
{
    public class Bouquet
    {
        int FlowerIndex = 0;
        int AccessoryIndex = 0;
        double Price = 0;
        Flower[] flowers;
        Accessory[] accessories = new Accessory[3];
        public Bouquet(int Size)
        {
            this.flowers = new Flower[Size];

        }

        public void InsertFlower(Flower flower)
        {
            flowers[FlowerIndex] = flower;
            FlowerIndex++;
            Price += flower.Price;
        }

        public void InsertAccessory(Accessory accessory)
        {
            accessories[AccessoryIndex] = accessory;
            AccessoryIndex++;
            Price += accessory.Price;
        }

        public void FlowerSort()
        {
            for (int i = 0; i < FlowerIndex; i++)
            {
                for (int j = i; j < FlowerIndex; j++)
                {
                    if (flowers[i].Freshness < flowers[j].Freshness)
                    {
                        Flower flower = flowers[i];
                        flowers[i] = flowers[j];
                        flowers[j] = flower;
                    }
                }
            }
        }

        public void FlowerSearch(int minLength, int maxLength)
        {
            Console.WriteLine("Пошук");
            bool IsInRange = false;
            for (int i = 0; i < FlowerIndex; i++)
            {
                if ((flowers[i].lengthOfFlower >= minLength) && (flowers[i].lengthOfFlower <= maxLength))
                {
                    flowers[i].Print();
                    IsInRange = true;
                }
            }
            if (!IsInRange)
            {
                Console.WriteLine("Нема квiтiв в дiапазонi");
            }
        }

        public void Print()
        { 
            Console.WriteLine("Квiти");
            for (int i = 0; i < FlowerIndex; i++)
            {
                 flowers[i].Print();
            }
            Console.WriteLine("Аксесуари");
          
                for (int i = 0; i < AccessoryIndex; i++)
                {
                    accessories[i].Print();
                }
         
            Console.WriteLine($"Цiна: {Price} грн");
        }
    }
}
