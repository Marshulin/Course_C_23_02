// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] MinEl(int[,] arr)
{
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] < arr[min_i, min_j])
            {
                min_i = i;
                min_j = j;
            }
    return new int[] {min_i, min_j};
}

int[,] EscapeRC(int[,] arr, int[] rocol)
{
    int row = rocol[0];
    int col = rocol[1];

    int[,] newarr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    
    for (int i = 0, a = 0; i < arr.GetLength(0); i++, a++)
    {
        if (i != row)
        {
            for (int j =0, b = 0; j < arr.GetLength(1); j++, b++)
            {
                if (j != col) 
                    newarr[a, b] = arr[i, j];
                else b--;
            }
        }
        else a--;
    }
    return newarr;
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

int[] rc = MinEl(mass);
int[,] new_mass = EscapeRC(mass, rc);
Console.WriteLine("Заданный двумерный массив с удалёнными строкой и столбцом, на пересечении которых расположен наименьший элемент массива: ");
Print(new_mass);
