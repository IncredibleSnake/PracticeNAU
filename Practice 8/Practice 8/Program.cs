using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1
            Console.Write("Введiть строку для реверсу: ");
            string input = Console.ReadLine();
            char[] inputarray = input.ToCharArray();    // Розбиваємо строку на масив символів
            
            Array.Reverse(inputarray);  // Інвертуємо символи
            
            string output = new string(inputarray);     // Збираємо масив в строку
            Console.WriteLine(output);

            // Задача 2
            Console.Write("Введiть строку для капiталiзацiї: ");
            var s = Console.ReadLine();

            var result = CapitalizeString(s);
            Console.WriteLine($"Результат: {result}");

            // Задача 3
            Console.Write("Введiть строку для пееревiрки на палiндром: ");
            var text = Console.ReadLine();
            var res = IsPalindrom(text) ? string.Empty : "не ";
            Console.WriteLine($"Строка \"{text}\" {res}є палiндромом");
            Console.ReadLine();
        }
        static string CapitalizeString(string s)    // Функція для другої задачі
        {
            // Розбиваємо строку на слова
            var parts = s.Split(' ');
            for (int i = 0; i < parts.Length; i++)
            {
                // Отримуємо першу букву
                var firstLetter = parts[i].Substring(0, 1).ToUpper();
                // Заміняємо стару букву
                parts[i] = firstLetter + parts[i].Remove(0, 1);
            }

            // З'єднуємо массив слів
            return string.Join(" ", parts);
        }
        static bool IsPalindrom(string text)    // Функція для третьої задачі
        {
            // Прибираємо пробіли
            var s = text.Replace(" ", string.Empty);
            // Зводимо все до нижнього реєстру
            s = s.ToLower();
            // Отримуємо індекс останнього слова
            int lastIndex = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                // Якщо символи не однакові виходимо з программи
                if (s[i] != s[lastIndex - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
