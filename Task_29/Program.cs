// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int length = 8;
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Введите значение элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(", ", array) + ']');