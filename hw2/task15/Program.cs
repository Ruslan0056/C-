System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 8) {
    System.Console.WriteLine("Такого дня не существует!");
} 
else if (day == 6 || day == 7) {
    System.Console.WriteLine("Сегодня выходной!");
} 
else {
    System.Console.WriteLine("Сегодня рабочий день.");
}