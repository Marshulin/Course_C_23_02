// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");

void TakeNum(int num)
{
    if(num > 5)
        Console.WriteLine("да");    
    else
        Console.WriteLine("нет");
}

TakeNum(int.Parse(Console.ReadLine()!));