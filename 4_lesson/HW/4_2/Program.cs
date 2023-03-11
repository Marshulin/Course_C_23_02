// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumNum(int num)
{
    int a = 0;
    for (int i = 1; num > 0; i++)
    {
        a+= num % 10;
        num/= 10;
    }
    return a;
}

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int result = SumNum(num);
Console.WriteLine(result);

// Console.WriteLine(452 % 10);
