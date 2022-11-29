﻿/* Задача 38. Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементом массива. 
 Например:
 3, 7, 22, 2, 78 -> 76
 */

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int y = 0; y < numbers.Length; y++)
{
    if (numbers[y] > max)
        {
            max = numbers[y];
        }
    if (numbers[y] < min)
        {
            min = numbers[y];
        }
}

Console.WriteLine($"В масиве всего чисел {numbers.Length}. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
