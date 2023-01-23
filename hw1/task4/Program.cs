
Console.WriteLine("Введите 3 числа!");
Console.Write("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (max < numberB)
{
    max = numberB;
    Console.WriteLine($"Наибольшее число {numberB}");
}

if (max < numberC)
{
    max = numberC;
    Console.WriteLine($"Наибольшее число {numberC}");
}

if (max == numberA)
{
    Console.WriteLine($"Наибольшее число {numberA}");
}