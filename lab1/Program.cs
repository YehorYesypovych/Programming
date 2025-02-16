using System;

class Program
{
    static void Main()
    {

        Random random = new Random();
        int listLength = random.Next(10, 21);
        List<int> list = new List<int>(listLength);

        for (int i = 0; i < listLength; i++)
        {
            list.Add(random.Next(-100, 101));
        }

        Console.WriteLine("Довжина списку  " + list.Count);

        Printer(list);
        Console.WriteLine();

        list.Sort();
        list.Reverse();

        Printer(list);
    }

    public static void Printer(List<int> listName)
    {
        for (int i = 0; i < listName.Count; i++)
        {
            Console.Write(listName[i] + ",");
        }
    }
}
