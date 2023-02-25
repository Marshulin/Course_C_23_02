// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

Console.WriteLine("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine()!);
if(a > b)
{
    Console.WriteLine("Первое число больше второго.");
}
if(a < b)
{
    Console.WriteLine("Первое число меньше второго.");
}
if(a == b)
{
    Console.WriteLine("Введённые числа равны!");
}