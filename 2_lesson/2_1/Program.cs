// 

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);

// int num = new Random().Next(100, 1000);

// Console.WriteLine(num % 10);