// Задача 3: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int SumDigits(int N)
{
    if (N == 0) return 0;
    return SumDigits(N / 10) + N % 10;
}

Console.WriteLine("N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write(SumDigits(n));