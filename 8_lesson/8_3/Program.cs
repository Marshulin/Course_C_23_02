// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

int[,] Create2DArray(int row, int columns)
{
    return new int[row, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i =0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(maxValue + 1);
}

string Print2DArray(int[,] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            res += array[i, j];
            if (j != array.GetLength(1) - 1)
                res+= "\t";
            else 
                res += "\n";
        }
    return res;
}

int[] Frequency( int[,] array, int maxValue)
{
    int[] dict = new int[maxValue +1];

    foreach (int element in array)
    {
        dict[element] += 1;
    }
    return dict;
}

string PrintFrequency(int[] array)
{
    string res = String.Empty;
    for (int i = 0; i < array.Length; i++)
        res += $"Число {i} встречается {array[i]} раз\n";
    return res;
}

int numRows = InputNum("Input a number of rows: ");
int numCols = InputNum("Input a number of columns: ");
int[,] myArray = Create2DArray(numRows, numCols);
int min = InputNum("Input a min value: ");
int max = InputNum("Input a max value: ");
Fill2DArray(myArray, min, max);
string result = Print2DArray(myArray);
Console.WriteLine(result);

int[] dictionary = Frequency(myArray, max);
string res = PrintFrequency(dictionary);

System.Console.WriteLine(res);
