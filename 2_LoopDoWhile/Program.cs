using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LoopDoWhile
{
    class Program
    {
        /*
         * Задачи на использование операторов цикла с постусловием. Осуществить ввод необходимых данных, выполнить реализацию 
         * алгоритма с использованием операторов цикла do - while, обеспечить вывод полученных результатов. Использование других 
         * операторов цикла недопустимо.
         * 
         * Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество 
         * отрицательных. Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
         */
        static void Main(string[] args)
        {
            int countMinus = 0;
            int countPlus = 0;
            int numRange; //Переменнная принимает введенное значение последовательности
            do
            {
                Console.WriteLine("Введите последовательность целых чисел. Введите 0 для окончания последовательности");
                numRange = Convert.ToInt32(Console.ReadLine());
                if (numRange > 0)
                    countPlus++;
                else
                    if (numRange == 0) //Проверка для первого значения. Если не проводить, то первая итерация цикла в случае введенного 0 приведет к неверно посчитанному количеству отрицательных значений
                    break;
                else countMinus++;

            } while (numRange!=0);
            if (countPlus==countMinus)
                Console.WriteLine($"Количество отрицательных и положительных чисел равно и составляет: {countPlus}");
            else
                Console.WriteLine(countPlus>countMinus?$"Больше положительных: {countPlus}":$"Больше отрицательных: {countMinus}");
            Console.ReadKey();
        }
    }
}
