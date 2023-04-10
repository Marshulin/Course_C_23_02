// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void NumsFromTo(int M, int N)
{
    if(M > N) return;
    NumsFromTo(M, N - 1);
    if ((N -1) % 2 != 0) Console.Write($"{N}, ");

}

Console.WriteLine("M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("N: ");
int n = int.Parse(Console.ReadLine()!);

NumsFromTo(m, n);