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
}

double[] FindAvg(int[,] mtrx)
{
    double[] arr = new double[mtrx.GetLength(1)];
    for (int i = 0; i < mtrx.GetLength(1); i++)
    {
        for (int j = 0; j < mtrx.GetLength(0); j++)
        {
            arr[i] += mtrx[j,i];
        }

        arr[i] = Math.Round(arr[i] / mtrx.GetLength(0), 1);
    }
    return arr;
}

void PrintArray(double[] arr)
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


double[] avg = FindAvg(matrix);
PrintArray(avg);


