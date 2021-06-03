using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_9
{
    class Program
    {
        //Метод обміну елементів
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        //Функція сортування вставками
        static int[] InsertionSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 0) && (array[j - 1] < key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }

            return array;
        }
        //Метод перестановки рядків масиву
        static void SwapLine(ref int[,] array, int t)
        {
            int[] temporaryArr = new int[array.GetLength(1)];
            for (int i = 0; i < temporaryArr.Length; i++)
            {
                temporaryArr[i] = array[t, i];
                array[t, i] = array[t-1, i];
                array[t-1, i] = temporaryArr[i];
            }
        }
        // Функція генерації матриці
        private static int[,] GenerateMatrix(int n, int a, int b)
        {
            int[,] myArr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArr[i, j] = rnd.Next(a, b);
                    Console.Write("{0,4}", myArr[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            return myArr;
        }
        static void Main(string[] args)
        {
            int min = 0;
            int n = 7; 
            int[] tempArr = new int[n];
            int[] sortArr = new int[n];
            int[] rankArr = new int[n];
            int[,] matrix = GenerateMatrix(n, -30, 30);
            for (int i = 0; i < matrix.GetLength(0); i++) // У цьому циклі ми сортуємо елементи в строках массиву від більшого до меншого
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tempArr[j] = matrix[i, j];
                }
                sortArr = InsertionSort(tempArr);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = sortArr[j];
                    sortArr[j] = 0;
                    tempArr[j] = 0;
                    Console.Write("{0,4}", matrix[i, j]);
                    if(matrix[i,j] < 0)
                    {
                        min++;  // Рахуємо кількість від'ємних чисел у строці
                    }
                }
                Console.Write("\n");
                rankArr[i] = min; // Записуємо кількість від'ємних чисел у строці
                min = 0;
            }
            for (var i = 0; i < rankArr.Length; i++)
            {
                var key = rankArr[i];
                var j = i;
                while ((j > 0) && (rankArr[j - 1] < key))
                {
                    Swap(ref rankArr[j - 1], ref rankArr[j]);    // При перестановці елементів у строці з кількістю від'ємних чисел
                    SwapLine(ref matrix, j);                     // Переставляємо строки
                    j--;
                }
                rankArr[j] = key;
            }
            Console.Write("\n");
            for (int i = 0; i < matrix.GetLength(0); i++)       // Виводимо результат
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}", matrix[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
       
    }
}
