// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string strA = Console.ReadLine();
int Length = 5;
if(strA.Length > Length || strA.Length < Length)
{
    Console.WriteLine($"Число {strA} - не пятизначное");
}
else
{
    char[] arr = strA.ToCharArray();
    Array.Reverse(arr);
    string strB = new String(arr);
    if (strA == strB) 
    {
        Console.WriteLine($"{strA} - палиндром");
    }
    else 
    {
        Console.WriteLine($"{strA} - Не палиндром");
    }
}