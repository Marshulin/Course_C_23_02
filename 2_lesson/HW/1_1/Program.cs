// Задача 1: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int TakeNum(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}

int result = TakeNum(num);


Console.WriteLine(result);
