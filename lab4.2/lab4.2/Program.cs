using System;
using System.IO;
using lab4._2;
using lab4._2.Accessories;
using lab4._2.Flowers;
class Program
{
    public static void Main(string[] args) 
    {
        Rose flower1 = new Rose();
        int a;
        Dandelion flower2 = new Dandelion();

        Tulip flower3 = new Tulip();

        Bow acc1 = new Bow();

        Tag acc2 = new Tag();

        Wrap acc3 = new Wrap();

        Bouquet bouquet = new Bouquet(3);
        bouquet.InsertFlower(flower1);
        bouquet.InsertFlower(flower2);
        bouquet.InsertFlower(flower3);
        bouquet.InsertAccessory(acc1);
        bouquet.InsertAccessory(acc2);
        bouquet.InsertAccessory(acc3);
       
        bouquet.Print();
        bouquet.FlowerSort();
        bouquet.Print();
        bouquet.FlowerSearch(7, 12);
        
    }
}