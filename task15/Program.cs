﻿/* Задача 15. Напишите программу, которая принимает на вход цифру
обозначающую день недели, и проверяет, является ли этот день выходным. 
 Например:
 6 -> да
 7 -> да
 1 -> нет
 */

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTneDayOfTheWeek (int dayNumber) 
{
    if (dayNumber == 6 || dayNumber == 7) {
    Console.WriteLine("(Этот день недели выходной?) -> Да");
    }
    else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Это не день недели!");  
    }
    else Console.WriteLine("(Этот день недели выходной?) -> Hет");
}

CheckingTneDayOfTheWeek(dayNumber);