Console.Clear();

Random rand = new Random();
int[,] Fillmatrix(int rows, int columns)
{
    int[,] mtrx = new int[rows,columns];
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i,j] = rand.Next(-10, 11);
            }
        }
    } 
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                System.Console.Write(mtrx[i,j] + "\t");
            }
            System.Console.WriteLine();
    }    
}

int[] FindSum(int[,] mtrx)
{
    int[] sumRows = new int[mtrx.GetLength(0)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                sumRows[i] += mtrx[i,j];
            }         
    }   
    return sumRows; 
}

void FindMinSum(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    } 
    System.Console.WriteLine($"Строка с наименьшей суммой - {minIndex + 1}.");
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

System.Console.WriteLine("Введите размеры матрицы!");
System.Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Fillmatrix(n,m);
PrintMatrix(matrix);

System.Console.WriteLine();
int[] minSum = FindSum(matrix);
PrintArray(minSum);
System.Console.WriteLine();
FindMinSum(minSum);










