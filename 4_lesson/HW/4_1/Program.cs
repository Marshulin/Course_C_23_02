// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int ExponNum(int A, int B)
{
    int expon = 1;
    for (int i = 1; i <= B; i++)
        expon *= A;

    return expon;
}

Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Bведите второе число");
int B = int.Parse(Console.ReadLine()!);
int result = ExponNum(A, B);
Console.WriteLine("Число A в натуральной степени B: " + result);
