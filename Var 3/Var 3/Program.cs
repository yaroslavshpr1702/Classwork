using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//  Шпрыгин Ярослав
//      10МИ2
//    Вариант №3

namespace Var_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");                  
            int N = int.Parse(Console.ReadLine());                      //Вводим размер массива

            int[,] a = new int[N, N];                                   //Двумерный массив
            int[] c = new int[N];                                       //Одномерный пустой массив
            int n = 1;                                                  //Начальное значение массива

            for (int i = 0; i < c.Length; i++)                          //Заполняем одномерный массив
            {
                c[i] = n;
                n = n + 1;                                              //Увеличиваем следующее значение массива на 1
            }

            for (int i = 0; i < N; i++)                                 //Формируем двумерный массив
            {
                for (int j = 0; j < N; j++)
                {
                    if (j <= i)
                    {
                        a[i, j] = c[i];                                 //Присваиваем значение элемента одномерного массива двумерному
                        c[i] = c[i] - 1;                                //Уменьшение значения элемента массива в следующем столбце на 1
                    }
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
