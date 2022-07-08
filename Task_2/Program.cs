// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
else if (numberA < numberB)  
    Console.WriteLine($"Число {numberB} больше числа {numberA}");
else
    Console.WriteLine("Числа равны");

    