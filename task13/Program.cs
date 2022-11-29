/* Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. 
 Например:
 456 -> 5
 78 -> третьей цифры нет
 32679 -> 6
 */

Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
Console.WriteLine("Третья цифра числа -> " +anyNumberText[2]);
}
else
{
Console.WriteLine("-> Третьей цифры нет.");  
}