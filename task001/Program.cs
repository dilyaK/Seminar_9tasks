﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ObrSchet (int b)
{
    if (b == 0) return 1;
    Console.Write("{0,4}", b);
    return ObrSchet(b - 1);
}

Console.WriteLine("Введите натуральное число больше 1:");
int a = Convert.ToInt32(Console.ReadLine());
if(a<1) Console.WriteLine("Число не больше 1");
else ObrSchet(a);
