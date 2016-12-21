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
            string str;
            int N, M, i, j;
            int[ , ] n = new int [25, 25];
            Random rnd = new Random();

            Console.Write("Введите кол-во столбцов в массиве: ");
            str = Console.ReadLine();
            M = int.Parse(str);

            Console.Write("Введите кол-во строк в массиве: ");
            str = Console.ReadLine();
            N = int.Parse(str);

            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    n[i,j] = rnd.Next(1,100);
                    
                    Console.Write("{0,4}", n[i,j]);
                };
                Console.WriteLine();
            };
            Console.WriteLine('\n');

            Console.WriteLine("Новый массив" + '\n');
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < M; j++)
                {
                    n[i,j] = n[i,j + M/2];
                    Console.Write("{0,4}", n[i, j]);
                };
                Console.WriteLine();
            };
                Console.ReadKey();
        }
    }
}
