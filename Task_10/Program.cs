﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int dig1 = 0;
int dig2 = 0;
int dig3 = 0;
if (numA < 100 | numA >= 1000)
{
    Console.WriteLine("Введенное число не является трехзначным: ");
}
else
{
    dig1 = numA / 100;
    dig3 = numA % 10;
    dig2 = (numA - dig1 * 100 - dig3) / 10;
    Console.WriteLine(dig2);
}

