﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void TochkaX(double b1, double k1, double b2, double k2)
{
    double len = k1 - k2;
    if (len != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Прямые пересекаются в точке: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые имеют бесконечное множество пересечений.");
    else
        Console.WriteLine("Точек пересечения нет.");

}

double b1 = double.Parse(Console.ReadLine()!);
double k1 = double.Parse(Console.ReadLine()!);
double b2 = double.Parse(Console.ReadLine()!);
double k2 = double.Parse(Console.ReadLine()!);

TochkaX(k1, b1, k2, b2);