﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA >= numberB && numberA >= numberC)
{
    Console.WriteLine($"Число {numberA} - максимум");
}
else if (numberB >= numberA && numberB >= numberC)
{
    Console.WriteLine($"Число {numberB} - максимум");
}
else
{
    Console.WriteLine($"Число {numberC} - максимум");
}