// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
Console.WriteLine("Enter the start number:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the end number:");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int SumRecurs(int M, int N)
{
    if (M > N)
    {
        return sum;
    }
    else
    {
        sum = sum + (M++);
    }
    return SumRecurs(M, N);
}

Console.WriteLine ($" The sum of natural numbers from {M} to {N} is: {SumRecurs(M, N)}");
