﻿/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу чисел от 1 до N. 
 Например:
 3 -> 1,8,27
 5 -> 1,8,27,64,125
 */

int number = ReadInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
