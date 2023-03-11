// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

void Massiv(int mas, int min, int max)
{
    int[] numbers = new int[mas];
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(min, max);
        Console.Write(numbers[i] + ",");
    }
}

Console.WriteLine("Введите число элементов массива");
int mas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число");
int max = int.Parse(Console.ReadLine()!);
Massiv(mas, min, max );

