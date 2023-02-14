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

int VolEvenNumb(int[] arr) 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) {
            count++;
        }
    }
    return count;
}

void PrintVolEvenNumb(int count)
{
    System.Console.WriteLine($"В заданном массиве {count} четных элементов.");
}


int[] arr = FillArr(20, 100, 999);
PrintArray(arr);
int vol = VolEvenNumb(arr);
PrintVolEvenNumb(vol);
