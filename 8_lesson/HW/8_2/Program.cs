// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumRowEl(int[,] arr)
{
    int[] sumrowel = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            sumrowel[i] =+ arr[i, j];
    return sumrowel;
    
}

int RowWhithMinS(int[] arr)
{
    int rowwhithmins = 0;
    for (int i = 1; i < arr.Length; i++)
        while (arr[i] <  arr[rowwhithmins]) rowwhithmins = i;
    return rowwhithmins;
}

Console.WriteLine("Размер прямоугольного двухмерного массива: ");
int row_num = int.Parse(Console.ReadLine()!);
int column_num = row_num;
Console.WriteLine("от: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("до: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Console.WriteLine("Заданный двумерный массив: ");
Print(mass);

int[] sums = SumRowEl(mass);
int num = RowWhithMinS(sums);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {num + 1}");

