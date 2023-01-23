Console.Clear();

System.Console.WriteLine("Введите координаты.");
System.Console.WriteLine("Первая точка:");
double[] pointA = {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};
System.Console.WriteLine("Вторая точка:");
double[] pointB = {Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())};


double length = Math.Sqrt(Math.Pow(pointA[0] - pointB[0],2) + Math.Pow(pointA[1]-pointB[1],2) + Math.Pow(pointA[2]-pointB[2],2));
System.Console.WriteLine($"Расстояние между двумя точками равно: {length}");
