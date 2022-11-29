/* Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
какое число больше, а какое меньше.
Пример: 
a=5; b=7 -> = 7
a=2; b=10 -> = 10
a=-9; b=-3 -> = 7 
*/

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
    {
        Console.Write("max = "); 
        Console.WriteLine(numberA);
    }
else
    {
        Console.Write("max = "); 
        Console.WriteLine(numberB);
    }
if (numberA < numberB)
    {
        Console.Write("min = "); 
        Console.WriteLine (numberA);
    }
else
    {
        Console.Write("min = ");
        Console.WriteLine(numberB);
    }