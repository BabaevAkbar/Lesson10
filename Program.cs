using System;
using System.Collections.Generic;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Задание 1
            // List<int> a = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // List<int> b = new List<int>();

            // a.Add(11);
            // a.Add(12);

            // Console.Write("Список после добавоения: ");
            // foreach(int i in a)
            // {
            //     Console.Write($"{i} ");
            // }
            // Console.WriteLine();

            // foreach(int i in a)
            // {
            //     if(i % 2 != 0)
            //     {
            //         b.Add(i);
            //     }
            // }

            // Console.Write("Список после удаления четных чисел: ");
            // foreach(int j in b)
            // {
            //     Console.Write($"{j} ");
            // }
            // Console.WriteLine();

            // Console.Write("Первое число больше 5: ");
            // foreach(int i in b)
            // {
            //     if(i > 5)
            //     {
            //         Console.WriteLine($"{i} ");
            //         break;
            //     }    
            // }

            // Console.Write("Список в обратном порядке: ");
            // for(int i = b.Count-1; i >= 0; i--)
            // {
            //     Console.Write($"{b[i]} ");
            // }

            // Задание 2
            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                ["Россия"] = "Москва",
                ["Франция"] = "Париж",
                ["Германия"] = "Берлин"
            };

            countries.Add("Таджикистан", "Душанбе");
            countries.Add("Узбкистан", "Ташкент");
            countries.Add("Великобритания", "Лондон");

            Console.WriteLine("Словарь после добавления: ");
            foreach(var country in countries)
            {
                Console.WriteLine($"Страна: {country.Key}. Столица: {country.Value}.");
            }


            if(countries.ContainsKey("Италия") == false)
            {
                countries.Add("Италия", "Рим");
            }

            countries.Remove("Франция");
            Console.WriteLine();

            Console.WriteLine("Удаленный элемент: {\"Франция\": \"Париж\"}");
            Console.WriteLine();
            foreach(var country in countries)
            {
                Console.WriteLine($"Страна: {country.Key}. Столица: {country.Value}.");
            }


            countries.TryGetValue("Германия", out string? b);
            Console.WriteLine($"Столица Германии: {b}");
        }
    }
}