using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LoopFor
{
    class Program
    {
        /*
         * Задачи на использование операторов цикла for. Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла
         * for, обеспечить вывод полученных результатов. Не разрешается использовать другие операторы цикла.
         * 
         * Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу:
         * N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех
         * целых чисел от 1 до N).
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N, большее 0:");
            int N = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"Квадрат числа {i} равен {Sum += 2 * i - 1}");
                }
            }
            else
                Console.WriteLine("Введенно неверное значение");
            Console.ReadKey();
        }
    }
}
