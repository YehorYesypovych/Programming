//using System;

//class Program
//{
//    static void Main()
//    {

//        Random random = new Random();
//        int listLength = random.Next(10, 21);
//        List<int> list = new List<int>(listLength);

//        for (int i = 0; i < listLength; i++)
//        {
//            list.Add(random.Next(-100, 101));
//        }

//        Console.WriteLine("Довжина списку  " + list.Count);

//        Printer(list);
//        Console.WriteLine();

//        list.Sort();
//        list.Reverse();

//        Printer(list);
//    }

//    public static void Printer(List<int> listName)
//    {
//        for (int i = 0; i < listName.Count; i++)
//        {
//            Console.Write(listName[i] + ",");
//        }
//    }
//}











//using System;
//using System.Text.Json;

//class Program
//{
//   

//    static Random random = new Random();

//    static void Main()
//    {

//        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>()
//        {
//            { 1, GenerateRandlist() },
//            { 2, GenerateRandlist() },
//            { 3, GenerateRandlist() },
//            { 4, GenerateRandlist() }
//        };
//        Console.WriteLine("Словник: ");
//        foreach (var data in dict)
//        {
//            Console.WriteLine($"{data.Key}: {string.Join(", ", data.Value)}");
//        }

//        Dictionary<int, int> result = new Dictionary<int, int>();

//        foreach (var item in dict)
//        {
//            result[item.Key] = Sum(item.Value);
//        }

//        Console.WriteLine("\nРезультат: ");
//        foreach (var item in result)
//        {
//            Console.WriteLine($"{item.Key}: {item.Value}");
//        }

//        string json = JsonSerializer.Serialize(result);
//        File.WriteAllText("resultdict.json", json);

//        Console.WriteLine("\nРезультат збережено у файл 'resultdict.json'.");

//        string context = File.ReadAllText("resultdict.json");
//        Console.WriteLine(context);
//    }

//    public static List<int> GenerateRandlist()
//    {
//        List<int> list = new List<int>();
//        int listLength = random.Next(3, 8);

//        for (int i = 0; i < listLength; i++)
//        {
//            list.Add(random.Next(0, 31));
//        }

//        return list;
//    }

//    public static int Sum(List<int> list)
//    {
//        int sum = 0;
//        foreach (int num in list)
//        {
//            sum += num;
//        }
//        return sum;
//    }

//}










//using System;

//class Program
//{


//    static void Main()
//    {
//        Random random = new Random();
//        int listLength = random.Next(4, 20);
//        List<int> list = new List<int>();

//        for (int i = 0; i < listLength; i++)
//        {
//            list.Add(random.Next(2, 101));
//        }

//        double finisher = list
//            .Select(n => n % 10)
//            .Aggregate(1.0, (total, current) => total * current);
//        foreach (int i in list)
//        {
//            Console.Write(i + ",");
//        }

//        Console.WriteLine($"\nДобуток останніх цифр: {finisher}");
//    }
//}