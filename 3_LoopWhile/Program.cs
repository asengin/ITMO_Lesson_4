using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LoopWhile
{
    class Program
    {
        /*
         * Задачи на использование операторов цикла с предусловием. Осуществить ввод необходимых данных, выполнить 
         * реализацию алгоритма с использованием операторов цикла while, обеспечить вывод полученных результатов. 
         * Использование других операторов цикла недопустимо.
         * 
         * Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество 
         * квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике. Операции 
         * умножения и деления не использовать.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону прямоугольника А");
            int rectA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввдетие сторону прямоугольника B");
            int rectB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата С");
            int sqrC = Convert.ToInt32(Console.ReadLine());
            int lenghtRectA = sqrC, lenghtRectB = sqrC;
            uint i = 0;

            if (rectA <= 0 || rectB <= 0 || sqrC <= 0)
                Console.WriteLine("Значения сторон прямоугольника и квадрата должны быть положительными и больше 0");
            else
            {
                while (lenghtRectB <= rectB)
                {
                    while (lenghtRectA <= rectA)
                    {
                        lenghtRectA += sqrC;
                        i++;
                    }
                    lenghtRectA = 1;
                    lenghtRectB += sqrC;
                }
            
            Console.WriteLine($"Количество квадратов со стороной С={sqrC} в прямоугольнике со сторонами А={rectA}, В={rectB}: {i}");
            }
            Console.ReadLine();
            
        }
    }
}
