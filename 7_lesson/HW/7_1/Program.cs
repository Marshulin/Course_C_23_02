// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print(double[,] arr)
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
	
	double[,] MassNums(int row, int column, int from, int to)
	{
	    double[,] arr = new double[row, column];
        Random n_new = new Random();
	
	    for (int i = 0; i < row; i++)
	        for (int j = 0; j < column; j++)
	            arr[i, j] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
	    return arr;
	}
	
    Console.WriteLine("Введите m - число рядов массива: ");
	int row_num = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите n - число колонок массива: ");
	int column_num = int.Parse(Console.ReadLine()!);
	Console.WriteLine("Введите нижнюю границу диапозона чисел массива: ");
    int start = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите верхнюю границу диапозона чисел массива: ");
	int stop = int.Parse(Console.ReadLine()!);
	
	double[,] mass = MassNums(row_num, column_num, start, stop);
    Console.WriteLine("Двумерный массив размером m на n, заполненный случайными вещественными числами: ");
	Print(mass);