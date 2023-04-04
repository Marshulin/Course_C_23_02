// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

bool Check(int row, int colum)
{
    bool result = (row != colum);
    return result;
}

string RowToCol(int[,] array)
{
    if (Check(array.GetLength(0), array.GetLength(1))) return "Не транспонируется!";

    for (int i = 1; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    PrintArray(array);
    return "Транспонируемая матрица: ";
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
string res = RowToCol(mass);
Console.WriteLine(res);
PrintArray(mass);
Console.WriteLine();


