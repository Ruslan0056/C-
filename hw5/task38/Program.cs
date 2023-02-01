Console.Clear();

double[] FillArr(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 3);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void FindMaxAndMin(double[] arr, out double max, out double min)
{
    max = 0;
    min = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (max < arr[i])
        {
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
}


double[] array = FillArr(5, -5, 5);

PrintArray(array);
FindMaxAndMin(array, out double max, out double min);
System.Console.WriteLine($"Максимальное число массива {max}, минимальное число массива {min}.");

System.Console.WriteLine("Разница между максимальным и минимальным числом равна " + (max - min) + ".");
