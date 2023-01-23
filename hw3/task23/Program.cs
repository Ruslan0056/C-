Console.Clear();


System.Console.Write("Введите число: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];

System.Console.Write($"Таблица кубов от 1 до {array.Length}: ");
for (int i = 0; i < array.Length + 1 ; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
    
}

System.Console.WriteLine();