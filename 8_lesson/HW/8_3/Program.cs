// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MassMultip(int[,] mass_1, int[,] mass_2)
{
    int row_num_1 = mass_1.GetLength(0);
    int column_num_1 = mass_1.GetLength(1);

    int row_num_2 = mass_2.GetLength(0);
    int column_num_2 = mass_2.GetLength(1);

    int[,] multip = new int[row_num_1, column_num_1];

    if (column_num_1 != row_num_2) return multip;
    else if (column_num_1 == row_num_2)
        multip = new int[row_num_1, column_num_2];
    
    for (int i = 0; i < row_num_1; i++)
    {
        for (int j = 0; j < column_num_2; j++)
        {
            for (int m = 0; m < column_num_1; m++)
                multip[i, j] += mass_1[i, m] * mass_2[m, j];
        }
    }
    return multip;

}

Console.WriteLine("Количество рядов: ");
int row_num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество колонок: ");
int column_num_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество рядов: ");
int row_num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество колонок: ");
int column_num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("от: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("до: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass_1 = MassNums(row_num_1, column_num_1, start, stop);
Console.WriteLine("матрица 1: ");
Print(mass_1);

int[,] mass_2 = MassNums(row_num_2, column_num_2, start, stop);
Console.WriteLine("матрица 2: ");
Print(mass_2);

int[,] res_mass = MassMultip(mass_1, mass_2);
Console.WriteLine("произведение двух матриц: ");
Print(res_mass);