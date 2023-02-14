Console.Clear();

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double[] FindIntersectionPoint(double k1, double b1, double k2, double b2)
{
    double[] IntersectionPoint = new double[2];
    IntersectionPoint[0] = -(b1 - b2) / (k1 - k2);
    IntersectionPoint[1] = k1 * IntersectionPoint[0] + b1; 
    return IntersectionPoint;
}

double ElemFromConsole(string str)
{
    double elem = 0;
    System.Console.Write($"{str} = ");
    elem = Convert.ToDouble(Console.ReadLine());
    return elem;
}


System.Console.WriteLine("Введите значения параметров:");
double k1 = ElemFromConsole("k1");
double b1 = ElemFromConsole("b1");
double k2 = ElemFromConsole("k2");
double b2 = ElemFromConsole("b2");

double[] arr = FindIntersectionPoint(k1, b1, k2, b2);
PrintArray(arr);

