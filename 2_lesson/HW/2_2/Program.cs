// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int TakeNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 100;
    int num3 = num % 10;
    int xten = num1 * 10;
    int newnum = xten + num3;
    
    return newnum;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);