// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA < 100 | numA > 999)
{
    Console.WriteLine("Введенное число не является трехзначным");
}
else
{
    // int dig1 = numA / 100;
    // int dig3 = numA % 10;       
    // int dig2 = (numA - dig1 * 100 - dig3) / 10; тоже работает, но много лишнего
    
    int dig2 = (numA / 10) % 10;
    Console.WriteLine(dig2);
}

