
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) {
    Console.WriteLine("Некорректное число");
}

for (int i = 1; i <= number; i++) {
    if (i % 2 == 0) {
        Console.Write($"{i}; ");
    }
}

Console.WriteLine();
