﻿// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
 
void Div(int num1, int num2)
{
    if (num1 % num2 == 0)
        Console.WriteLine("kratno");
    else 
        Console.WriteLine("nekratno " + num1 % num2);
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

Div(a, b);