// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($" {arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(0, 100);
    return arr;
}

int DivMaxMin(int[] mass)
{
    int max = mass[0];
    int min = mass[0];
    int div = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max)
        max = mass[i];
        // Console.WriteLine(max);
        
        if (mass[i] < min)
        min = mass[i];
        // Console.WriteLine(min);
        div = max - min;
    }
    return div;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num);
Console.WriteLine("массив");
Print(mass);

Console.WriteLine("Разница между макс и мин элементом массива -> " + DivMaxMin(mass));