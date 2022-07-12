// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int numA = Convert.ToInt32(Console.ReadLine());
if(numA > 7 | numA <= 0)
{
    Console.WriteLine("Допустимы только цифры от 1 до 7");
}
else if(numA >= 6)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}