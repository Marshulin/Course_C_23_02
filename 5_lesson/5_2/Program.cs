// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное чтсло в массиве.

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

void MassSearchNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == num)
            Console.WriteLine("yes");
            return;
        }
    Console.WriteLine("no");
}

Console.WriteLine("Введите длинну массива: ");
int mas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[] array = MassNums(mas, start, stop);
Print(array);

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
MassSearchNum(array, num);