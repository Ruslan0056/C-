System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number.Length < 3) {
    System.Console.WriteLine("Третьей цифры нет!");
}
else
{
    System.Console.WriteLine($"Третья цифра числа {number} - {number[2]}.");
}

int numberInt = Convert.ToInt32(number);

if (numberInt < 100) {
    System.Console.WriteLine("Третьей цифры нет!");
}
else
{
    while (numberInt >= 1000)
    {
        numberInt = numberInt / 10;
    }
    
    System.Console.WriteLine($"Третья цифра числа {number} - {numberInt % 10}.");
}


