using System;
using System.IO;
using System.Text.Json;
using lab2;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main()
    {
        Console.Write("Введіть години для першого часу: ");
        int h1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть хвилини для першого часу: ");
        int m1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть секунди для першого часу: ");
        int s1 = int.Parse(Console.ReadLine());

        Console.Write("Введіть години для другого часу: ");
        int h2 = int.Parse(Console.ReadLine());
        Console.Write("Введіть хвилини для другого часу: ");
        int m2 = int.Parse(Console.ReadLine());
        Console.Write("Введіть секунди для другого часу: ");
        int s2 = int.Parse(Console.ReadLine());

        Time time1 = new Time(h1, m1, s1);
        Time time2 = new Time(h2, m2, s2);

        Console.WriteLine($"Різниця в секундах: {Time.DifferenceInSeconds(time1, time2)}");

        Console.Write("Введіть кількість секунд для додавання: ");
        int secondsToAdd = int.Parse(Console.ReadLine());
        Time newTime = time1.AddSeconds(secondsToAdd);
        Console.WriteLine($"Новий час після додавання {secondsToAdd} секунд: {newTime}");

        string filePath = @"C:\Users\yehor\source\repos\lab2\lab2\Data.json";
        time1.SaveToJson(filePath);
        Console.WriteLine("Об'єкт збережено у JSON файл за шляхом: " + filePath);

        Time loadedTime = Time.LoadFromJson(filePath);
        Console.WriteLine($"Завантажений об'єкт: {loadedTime}");
    }
}