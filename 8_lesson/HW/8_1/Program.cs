// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
	int column = arr.GetLength(1);
	
	for (int i = 0; i < row; i++)
	{
	    for (int j = 0; j < column; j++)
	        Console.Write($" {arr[i, j]} ");
	    Console.WriteLine();
	}
}
	
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
	
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void NewMass(int[,] mass)
{
    int ArrayRow = mass.GetLength(0);
    int ArrayColum = mass.GetLength(1);
    
    for (int i = 0; i < ArrayRow; i++)
    {
        for (int j = 0; j < ArrayColum; j ++)
        {
            for (int k = 0; k < ArrayColum - j - 1; k++)
                if (mass[i, k] < mass[i, k + 1])
                    (mass[i, k], mass[i, k + 1]) = (mass[i, k + 1], mass[i, k]);
        }
    }
}
Console.WriteLine("Количество рядов: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество колонок: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("от: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("до: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Console.WriteLine("Заданный двумерный массив: ");
Print(mass);

NewMass(mass);
Console.WriteLine("Упорядоченные по убыванию элементы каждой строки: ");
Print(mass);