// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

void NumsFromTo(int M, int N)
{
    if(M == N + 1) return;
    NumsFromTo(M, N - 1);
    Console.Write($"{N}, ");

}

Console.WriteLine("M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("N: ");
int n = int.Parse(Console.ReadLine()!);

NumsFromTo(m, n);