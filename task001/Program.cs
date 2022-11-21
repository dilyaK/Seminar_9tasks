// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Enter the number:");
int a = Convert.ToInt32(Console.ReadLine());
int recursion (int n)
{
    if (n == 0) return 1;
    Console.Write("{0,4}", n);
    return recursion(n - 1);
}
if(a <  1 ) Console.WriteLine("0");
else recursion(a);
