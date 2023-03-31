// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int CountNum()
{
    int count = 0;
    string num;

    while (true)
    {
        Console.Write("Введите число или для Enter завершешия ввода: ");
        num = Console.ReadLine()!;

        if (num == "") return count;
        else if (int.Parse(num) > 0) count += 1;
    }
}

int count = CountNum();
Console.WriteLine($"Чисел больше 0: {count}");