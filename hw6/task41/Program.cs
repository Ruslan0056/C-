Console.Clear();

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] FillArrConsole(int vol)
{
    int[] array = new int[vol];
    for (int i = 0; i < vol; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

System.Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArrConsole(number);
PrintArray(arr);
int vol = CountPos(arr);

System.Console.WriteLine($"В заданном массиво {vol} элементов больше 0.");
