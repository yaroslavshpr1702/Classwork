using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//    Шпрыгин
//    Ярослав
//     10МИ2
//  Вариант № 22

namespace Var__22
{
    public class Program
    {
        public static int Sum(int n)
        {
            int sum = 0;                                                                            //Присваиваем начальное значение суммы
            
            for (int i = 0; i < n; i++)                                                             //Создаем масив
            {
                Console.Write("Введите цену товара из чека: ");
                int k = int.Parse(Console.ReadLine());                                              //Вводим цену N-ого товара

                if (k > 1000)                                                                       //В случае, если цена покупки превысит значение 1000, то
                    k = (k * 95) / 100;                                                             //значению цены покупки будет присвоено новое значение с учетом скидки в 5%
                
                sum = sum + k;
            }
            return sum;                                                                             //Возвращаем значение суммы
        }

        static void Main(string[] args)
        {
            char res = 'y';

            do                                                                                      //Запускаем цикл, пока символьное значение res присвоено значение 'y'
            {
                Console.Write("Введите количество товаров из чека: ");                              
                int N = int.Parse(Console.ReadLine());                                              //Вводим количество товаров

                int sum = Sum(N);                                                                   //Присваиваем значению суммы значение, взятое из метода Sum

                Console.WriteLine("Сумма чека составляет " + sum);                                  //Выводим сообщение о сумме чека

                Console.Write("Для повтора нажмите клавишу \"Y\": ");                               //Спрашиваем пользователя о повторе программы
                res = char.Parse(Console.ReadLine());                                               //Присваиваем значению результата новое значение
            } while (res == 'y' || res == 'Y');
        }
    }
}
