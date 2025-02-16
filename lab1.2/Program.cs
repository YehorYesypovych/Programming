using System;
using System.Text.Json;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>()
        {
            { 1, GenerateRandlist() },
            { 2, GenerateRandlist() },
            { 3, GenerateRandlist() },
            { 4, GenerateRandlist() }
        };

        Console.WriteLine("Словник: ");
        foreach (var data in dict)
        {
            Console.WriteLine($"{data.Key}: {string.Join(", ", data.Value)}");
        }

        Dictionary<int, int> result = new Dictionary<int, int>();

        foreach (var item in dict)
        {
            result[item.Key] = Sum(item.Value);
        }

        Console.WriteLine("\nРезультат: ");
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        string json = JsonSerializer.Serialize(result);

        string filePath = @"C:\Users\yehor\source\repos\lab1\lab1.2\resultdict.json";
        File.WriteAllText(filePath, json);

        Console.WriteLine($"\nРезультат збережено у файл '{filePath}'.");

        string context = File.ReadAllText(filePath);
        Console.WriteLine(context);
    }

    public static List<int> GenerateRandlist()
    {
        List<int> list = new List<int>();
        int listLength = random.Next(3, 8);

        for (int i = 0; i < listLength; i++)
        {
            list.Add(random.Next(0, 31));
        }

        return list;
    }

    public static int Sum(List<int> list)
    {
        int sum = 0;
        foreach (int num in list)
        {
            sum += num;
        }
        return sum;
    }
}
