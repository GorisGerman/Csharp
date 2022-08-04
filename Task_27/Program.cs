// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; numA != 0; i++)
{
    sum += numA % 10;
    numA /= 10;
}
Console.WriteLine(sum);