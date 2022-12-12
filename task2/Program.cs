// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.

// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Максимальное число: ");
// string message = "Максимальное число: "; 

    if (a > b) 
    {
        Console.Write(a); 
    }

    else 
    {
 
        Console.Write(b);
    }




