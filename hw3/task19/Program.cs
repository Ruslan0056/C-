Console.Clear();

System.Console.Write("Введите пятизначное число: ");

string number = Console.ReadLine();

if (number.Length != 5) {
    System.Console.WriteLine("Некорректное число");
}
else if (number[0] ==  number[4] && number[1] ==  number[3]) 
{
    System.Console.WriteLine($"{number} - палиндром.");
}
else
{
    System.Console.WriteLine($"{number} - непалиндром.");
}