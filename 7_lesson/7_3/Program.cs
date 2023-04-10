// Задача 3: Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.
// Например, задан массив:
// 1 4 7
// 5 9 2
// 8 4 2
// Сумма элементов главной диагонали: 1+9+2 = 12

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
    
int EvenPos(int[,] arr)
	{
	    int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
	
	    int sum = 0;
	
	    for (int i = 0; i < row; i++)
	        for (int j = 0; j < column; j++)
	
	            if (i == j)
	                sum = sum + arr[i, j];
	
	    return sum;            
	
	}
	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	
	int[,] mass = MassNums(row_num, column_num, start, stop);
	Print(mass);
	int result = EvenPos(mass);
	Console.WriteLine(result);