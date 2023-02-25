// 3
Console.WriteLine("Введите целое число: ");
int N = int.Parse(Console.ReadLine()!);
int b = - N;
while (b <= N)
{
    Console.Write($"{b} ");
    b ++;
}

