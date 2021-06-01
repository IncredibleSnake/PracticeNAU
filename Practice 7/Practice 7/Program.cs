using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            
            int m = 200;
            int n = 20;
            int[,] myArr = new int[n, m];
           
            double avg = 0;
            int counter = 0;
            int counterAvg = 0;
            try
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        myArr[i, j] = rnd.Next(-300, 300);
                        if (myArr[i, j] % 2 == -1)
                        {
                            counter++;
                            if (counter == 3)
                            {
                                counterAvg++;
                                avg += Convert.ToDouble(myArr[i, j]);
                                counter = 0;
                            }
                        }
                    }
                    if (counterAvg == 0)
                        Console.WriteLine("No Average");
                    else
                        Console.WriteLine($"{avg / counterAvg}");
                    counter = 0;
                    counterAvg = 0;
                    avg = 0;
                }
            }
            catch(IndexOutOfRangeException)    //Намагаємося зловити помилку розміру массива
            {
                Console.WriteLine("Проблема у массиві");
            }
        }
    }
}
