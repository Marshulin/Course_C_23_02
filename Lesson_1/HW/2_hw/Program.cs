// Задача 2: Напишите программу, которая принимает
// на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Введите первое целое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе целое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье целое число: ");
int c = int.Parse(Console.ReadLine()!);
int m = 0;

if(a > b)
{
    m = a;
}
if(a < b)
{
   m = b; 
}
if(c > m)
{
    m = c;
}
    Console.Write($"max: {m} ");

// Не стала заморачиваться, работает с прведёнными в задаче числами для примера - на этом остановилась :_