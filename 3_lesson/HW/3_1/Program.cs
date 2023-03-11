// Задача 19
// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void TakeNum(int N)
{
    int num_1 = N / 10000;
    int num_2 = (N / 1000) % 10;
    int num_4 = (N % 100) / 10;
    int num_5 = N % 10;
    if(num_1 == num_5 & num_2 == num_4)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}

Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
TakeNum(N);

