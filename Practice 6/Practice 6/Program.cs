using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створив об'кт для генерації випадкових чисел
            Random rnd = new Random();
            // Задаємо розмір нашого массива
            int m = 200;
            int n = 20;
            int[,] myArr = new int[n,m];
            // Створюємо змінну для середнього арифметичного та змінну лічильників
            double avg = 0;
            int counter  = 0 ;
            int counterAvg = 0;
            // Цимкл для перебору массиву, його заповнення та виконання завдання
            for (int i = 0; i < n; i++){   // Перебираємо елементи в строці 
                for(int j = 0; j < m; j++)     // Перебираємо елементи в стовбці
                {
                    myArr[i, j] = rnd.Next(-300, 300);    // Заповнюємо массив випадковими числами від -30 до 300
                    if (myArr[i, j] % 2 == -1)    //Проходять тільки від'ємні непарні числа
                    {
                        counter++;      // Проходить кожне третє число
                        if ( counter == 3)
                        {
                            counterAvg++;   //Рахуємо кількість потрібних нам чисел а також записуємо їх у змінну
                            avg += Convert.ToDouble(myArr[i, j]);
                            counter = 0;
                        }
                    }
                }
                if (counterAvg == 0)    // Перевірка виводу щоб не утворилось 0\0
                    Console.WriteLine("No Average");
                else
                    Console.WriteLine($"{avg / counterAvg}");     // Виводимо на екран середне арифметичне потрібних нам чисел з табуляцією
                counter = 0;    // Очищаємо змінні до наступного циклу
                counterAvg = 0;
                avg = 0;
            }
        }
    }
}
