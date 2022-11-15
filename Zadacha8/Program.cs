﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число  ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (n > 1)
{
    Console.WriteLine($"В диапазон от 1 до {n} входят следующие четные числа:");
    while (i <= n - 2)
    {
        Console.Write($"{i}, ");
        i = i + 2;
    }
    Console.Write($"{i}");
}
else
{
    Console.WriteLine("Введёное число не входит в допустимый диапазон, число должно быть больше нуля");
}
