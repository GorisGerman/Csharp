// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int I = 1;
while (I < N + 1)
{
    Console.WriteLine(Math.Pow(I, 3));
    I++;
}