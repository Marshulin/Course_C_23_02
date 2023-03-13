// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($" {arr[i]} ");
    Console.WriteLine();
}

int SumFlatNums(int[] mass)
{
    int sumFlat = 0;
    for (int i = 0; i < mass.Length; i = i + 2)
        sumFlat += mass[i];
        return sumFlat;
}

Console.WriteLine("Введите размер массива");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начало");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите окончание");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

Console.WriteLine("->" + SumFlatNums(mass));
