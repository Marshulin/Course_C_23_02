﻿// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int Expon(int A, int B)
{
    if (B == 0) return 1;
    return A * Expon(A, B - 1);
}

Console.WriteLine("A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("B: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write(Expon(a, b));