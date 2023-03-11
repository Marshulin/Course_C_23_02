
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

void MassConverter(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array[i] = - array[i];
}

Console.WriteLine("Введите длинну массива: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное число массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное число массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[] masRandom = MassNums(num, start, stop);
Print(masRandom);
MassConverter(masRandom);
Print(masRandom);
