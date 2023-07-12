// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");

int f(int a)
{
    int a2 = ( a % 100) / 10;
    return a2;    
}

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(a));
