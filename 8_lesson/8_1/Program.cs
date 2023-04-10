// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] FillMassive(int row, int colum, int from, int to)
{
    int[,] mass = new int[row,colum];

    for (int i = 0; i < row; i ++)
    {
        for (int j = 0; j < colum; j ++)
        {
            mass[i, j] = new Random().Next(from, to);
        }
    }
    return mass;
}

void PrintArray(int[,] array)
{
    int RowLength = array.GetLength(0);
    int ColumLength = array.GetLength(1);

    for (int i = 0; i < RowLength; i ++)
    {
        for (int j = 0; j < ColumLength; j ++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void ReplaceIndex(int[,] array)
{
    int ArrayRow = array.GetLength(0);
    int ArrayColum = array.GetLength(1);

    for (int j = 0; j < ArrayColum; j ++)
    {
        (array[0, j], array[ArrayRow - 1, j]) = (array[ArrayRow - 1, j], array[0, j]);
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colum = int.Parse(Console.ReadLine()!);
Console.Write("Введите насальное значение: ");
int from = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное значение: ");
int to = int.Parse(Console.ReadLine()!);

int[,] mass = FillMassive(row, colum, from, to);
PrintArray(mass);
Console.WriteLine();
ReplaceIndex(mass);
PrintArray(mass);