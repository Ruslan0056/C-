System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.Length != 3) {
    System.Console.WriteLine("Неверное число!");
}
else
{
    System.Console.WriteLine($"Вторая цифра числа {number} - {number[1]}.");
}

int numberInt = Convert.ToInt32(number);

if (numberInt < 100 || numberInt > 999) {
    System.Console.WriteLine("Неверное число!");
}
else
{
    System.Console.WriteLine($"Вторая цифра числа {numberInt} - {numberInt / 10 % 10}.");
}


