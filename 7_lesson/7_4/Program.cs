// Задача 4: Задайте двумерный массив. Введите элемент, и найдите
// первое его вхождение, выведите позиции по горизонтали и
// вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

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

string SearchNum(int[,] arr, int num)
	{
	    int row = arr.GetLength(0);
	    int column = arr.GetLength(1);
	
	    
	    for (int i = 0; i < row; i++)
	        for (int j = 0; j < column; j++)
	
	            if (arr[i,j] == num)
	             return $"[{i+1},{j+1}]";
	    return "РўР°РєРѕРіРѕ С‡РёСЃР»Р° РЅРµС‚";
	        
	                
	}
	
	int row_num = int.Parse(Console.ReadLine()!);
	int column_num = int.Parse(Console.ReadLine()!);
	int start = int.Parse(Console.ReadLine()!);
	int stop = int.Parse(Console.ReadLine()!);
	
	int[,] mass = MassNums(row_num, column_num, start, stop);
	Print(mass);
	int val = int.Parse(Console.ReadLine()!);
	
	string result = SearchNum(mass, val);
	Console.WriteLine(result);