// Задача 3: Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры
// нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");

void TakeNum(int num)
{
    if(num > 99 & num < 1000)
        Console.WriteLine("Третья цифра: " + num % 10);    
    if(num < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return;
    }
    while (num > 999) num /= 10;
        Console.WriteLine("Третья цифра: " + num % 10);
}

TakeNum(int.Parse(Console.ReadLine()!));



