
Console.WriteLine("Введите 2 числа!");
Console.Write("Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) {
    Console.WriteLine($"Большее число - {numberA}, меньшее число - {numberB}.");
    } 
else if (numberA < numberB)
{
    Console.WriteLine($"Большее число - {numberB}, меньшее число - {numberA}.");
}
else
{
    Console.WriteLine("Числа равны.");
}