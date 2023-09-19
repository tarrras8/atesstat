//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;

namespace SumOfNaturals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение M:");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение N:");
            int N = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = M; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна: {sum}");
            Console.ReadKey();
        }
    }
}


