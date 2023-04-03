// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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

    bool CheckNum(int row, int column, int I, int J)
    {
        return I >= 0 && J >= 0 && I < row && J < column;
    }
	
    string SearchNum(bool check, int[,] arr, int I, int J)
    {
        string val = "Нет такого индекса в массиве.";
        if (check == true) val = $"По данному индексу хранится число: {arr[I - 1, J - 1]}.";
        return val;
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

    Console.WriteLine("Введите индекс ряда: ");
	int I = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите индекс колонки: ");
	int J = int.Parse(Console.ReadLine()!);

    bool check = CheckNum(row_num, column_num, I, J);

	
	string result = SearchNum(check, mass, I, J);
	Console.WriteLine(result);