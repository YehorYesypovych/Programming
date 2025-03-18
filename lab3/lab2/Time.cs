using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace lab2
{
    public class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public static int DifferenceInSeconds(Time t1, Time t2)
        {
            return Math.Abs(t1.ToTotalSeconds() - t2.ToTotalSeconds());
        }

        public Time AddSeconds(int seconds)
        {
            int totalSeconds = ToTotalSeconds() + seconds;
            int newHours = (totalSeconds / 3600) % 24;
            int newMinutes = (totalSeconds % 3600) / 60;
            int newSeconds = totalSeconds % 60;
            return new Time(newHours, newMinutes, newSeconds);
        }

        public Time AddMinutes(int minutes)
        {
            return AddSeconds(minutes * 60);
        }

        public void SaveToJson(string filePath)
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static Time LoadFromJson(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл не знайдено");

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Time>(json);
        }
    }
}

