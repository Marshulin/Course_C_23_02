
void Quarters(int num)
{
    if (num == 1)
        Console.WriteLine("x > 0, y > 0");
    else if (num == 2)
        Console.WriteLine("x < 0, y > 0");
    else if (num == 3)
        Console.WriteLine("x < 0, y < 0");
    else if (num == 4)
        Console.WriteLine("x > 0, y < 0");
    else 
        Console.WriteLine("Четверти всего 4");
}

int num = int.Parse(Console.ReadLine()!);

Quarters(num);