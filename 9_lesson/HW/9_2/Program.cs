// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SunNumsFromTo(int M, int N)
{
    if(M > N) return 0;
    return M + SunNumsFromTo(M + 1, N);
}

Console.WriteLine("M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("суммa натуральных элементов в промежутке от M до N с помощью рекурсии: ");
Console.Write(SunNumsFromTo(m, n));

