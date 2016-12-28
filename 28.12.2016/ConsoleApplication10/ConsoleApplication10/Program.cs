using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк и столбцов: ");
            string str = Console.ReadLine();
            int K = int.Parse(str);

            int[,] a = new int[K, K];
            int sum = 0;
            Random rnd = new Random();

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    a[i, j] = rnd.Next(0, 9);
                    if (i <= j)
                        sum = sum + a[i, j];
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Сумма элементов в заданной области: " + sum);

            Console.ReadKey();
        }
    }
}
