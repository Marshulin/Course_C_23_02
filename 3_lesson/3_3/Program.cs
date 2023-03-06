
void TakeNum(int N)
{
    int count = 1;
    while(count <= N)
    {
        Console.WriteLine(Math.Pow(count,2));
        count ++;
    }

}

int N = int.Parse(Console.ReadLine()!);
TakeNum(N);
