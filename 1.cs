// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        PrintReverse(N);

        Console.ReadKey();
    }

    static void PrintReverse(int num)
    {
        if (num == 1)
        {
            Console.Write(num + " ");
        }
        else
        {
            PrintReverse(num - 1);
            Console.Write(num + " ");
        }
    }
}