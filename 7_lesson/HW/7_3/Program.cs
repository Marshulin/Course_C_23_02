// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

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

double[] ColAve(int[,] arr)
{
    double[] average = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
            average[i] += arr[j, i];
        average[i] /= arr.GetLength(0);
    }
    return average;
}

string PrintColAveArr(double[] arr)
{
	string res = String.Empty;
	for (int i = 0; i < arr.Length; i ++)
	{
		res += Math.Round(arr[i], 2);
		if (i != arr.Length -1) res += "; ";
		else res += ".";
	}
	return res;
}

Console.WriteLine("Введите m - число рядов массива: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n - число колонок массива: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите нижнюю границу диапозона чисел массива: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите верхнюю границу диапозона чисел массива: ");
int stop = int.Parse(Console.ReadLine()!);
	
int[,] mass = MassNums(row_num, column_num, start, stop);
Console.WriteLine("Двумерный массив, заполненный случайными числами: ");
Print(mass);

double[] result = ColAve(mass);
string avg = PrintColAveArr(result);
Console.WriteLine(avg);