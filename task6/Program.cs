/* Задача 6: Напишите программу, которая на вход принимает число 
и выдает являится ли число четным (делится ли оно на два без остатка).
Пример: 
4 -> Да
-3 -> нет
7 -> нет 
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
