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