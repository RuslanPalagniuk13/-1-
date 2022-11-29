/* Задача 10. Напишите программу, которая принимает на вход трехзначное число
и проверяет и на выходе показывает вторую цифру этого числа. 
 Например:
 456 -> 5
 782 -> 8
 918 -> 1
 */

Console.Write("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.Write("Вторая цифра числа: " +stringNumber[1]);
