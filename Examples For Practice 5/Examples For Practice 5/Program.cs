using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples_For_Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int minPrice = 20;

            Console.Write("Введіть ціну товару:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Варіант 1 - && логічне І");

            //У цьому прикладі ми використовуємо логічне І, та придбаємо усі товари від 20 до 100 грн
            if (minPrice <= price && price <= money)
            { 
                Console.WriteLine("Придбаємо");
            }
            else
            {
                Console.WriteLine("Не придбаємо");
            }

            Console.WriteLine();
            Console.WriteLine("Варіант 2 - || логічне АБО");
            //У цьому прикладі ми використовуємо логічне АБО, та придбаємо товари менше 20 грн або більше 100 грн
            if (price < minPrice || price > money)
            {
                Console.WriteLine("Не придбаємо");
            }
            else
            {
                Console.WriteLine("Придбаємо");
            }

            Console.WriteLine();
            Console.WriteLine("Варіант 3 - ! НЕ та || логічне АБО");
            //У цьому прикладі ми використовуємо логічні НЕ та АБО, також купляємо усі товари окрім тих що дешевше 20грн та дорожче 100грн
            if (!(price < minPrice || price > money))
            {
                Console.WriteLine("Придбаємо");
            }
            else
            {
                Console.WriteLine("Не придбаємо");
            }
        }
    }
}
