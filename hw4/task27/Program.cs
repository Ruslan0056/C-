int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        
        System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз!");
    }
    return number;
}

int SumOfN(int number)
{
    int N = number;
    int sum = 0;
    while (number > 0)
    {
        sum += number%10;
        number = number / 10;
    }
    System.Console.WriteLine($"Сумма всех цифр числа {N} равна {sum}.");
    return 0;
}

Console.Clear();

int numberA = InputNumber("Введите число: ");
SumOfN(numberA);
