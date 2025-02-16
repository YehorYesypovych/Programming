using System;

class Program
{


    static void Main()
    {
        Random random = new Random();
        int listLength = random.Next(4, 20);
        List<int> list = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            list.Add(random.Next(2, 101));
        }

        double finisher = list
            .Select(n => n % 10)
            .Aggregate(1.0, (total, current) => total * current);
        foreach (int i in list)
        {
            Console.Write(i + ",");
        }

        Console.WriteLine($"\nДобуток останніх цифр: {finisher}");
    }
}