/* Задача 4: Напишите программу, которая принимает на вход три числа 
и выдает максимальное из них.
Пример: 
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22 
*/

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 1;
if (numberA > numberB) 
{
Console.WriteLine("max = numberA");
}
if (numberB > numberC) 
{
Console.WriteLine("max = numberB");
}
else 
{
Console.WriteLine(max = numberC);
}

