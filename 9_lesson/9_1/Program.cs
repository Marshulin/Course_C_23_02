// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void SeriesNums(int N)
{
    if(N == 0) return;
    SeriesNums(N - 1);
    Console.Write($"{N}, ");

}

SeriesNums(int.Parse(Console.ReadLine()!));

