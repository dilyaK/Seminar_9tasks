// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Recursion (int m)
{
    if (m == 0) return 1;
    Console.Write("{0,4}", m);
    return Recursion(m - 1);
}
Console.WriteLine("Enter the number:");
int n = Convert.ToInt32(Console.ReadLine());
if(n <  1 ) Console.WriteLine("0");
else Recursion(n);
