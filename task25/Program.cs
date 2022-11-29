/* Задача 25. Напишите цикл, который принимает на вход два числа А и В 
и возводит в натуральную степень В. 
 Например:
 3,5 -> 243
 2,4 -> 16
 */

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
  return result;
}

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);
