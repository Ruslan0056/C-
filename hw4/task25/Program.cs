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

int DegreeAToB (int numberA, int numberB) {
    int newNumberA = numberA;
    for (int i = 1; i < numberB; i++)
    {
        newNumberA *= numberA;
    }
    System.Console.WriteLine($"{numberA} в степени {numberB} равно {newNumberA}.");
    return 0;
}

Console.Clear();

int numberA = InputNumber("Введите число: ");
int numberB = InputNumber("Введите число: ");

int degreeA = DegreeAToB(numberA, numberB);