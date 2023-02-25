// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все
// чётные числа от 1 до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число N: ");
        int N = int.Parse(Console.ReadLine()!);
        int b = 2;
        Console.WriteLine("Чётные числа от 1 до N");
        while (b <= N)
        {
            Console.Write($"{b} ");
            b = b + 2;
        }
    }
}

// без исключения и предупреждений возможных "вводов" ломающих программку