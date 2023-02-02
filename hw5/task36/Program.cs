Console.Clear();

int[] FillArr(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int SumElemEventIndex(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 != 0) {
            sum += arr[i];
        }
    }
    return sum;
}

void PrintSumElemEventIndex(int sum)
{
    System.Console.WriteLine($"Сумма элементов, находящихся на нечетных позициях, равна {sum}.");
}


int[] array = FillArr(20, -10, 10);
PrintArray(array);
int sum = SumElemEventIndex(array);
PrintSumElemEventIndex(sum);