﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;
while (A < N + 1)
{
    if ((A % 2) == 0)
        Console.WriteLine(A);
    A++;
}
