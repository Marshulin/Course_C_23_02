
int CompNum(int num)
{
    int all_comp = 1;
    for (int i = 1; i <= num; i++)
        all_comp *= i;

    return all_comp;
}

int A = int.Parse(Console.ReadLine()!);
int result = CompNum(A);
Console.WriteLine(result);
