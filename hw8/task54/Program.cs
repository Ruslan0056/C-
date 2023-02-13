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

int[,] Streamline(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < mtrx.GetLength(1) - 1; k++)
                if (mtrx[i,k] < mtrx[i,k+1])
                {
                    int max = mtrx[i,k];
                    mtrx[i,k] = mtrx[i,k+1];
                    mtrx[i,k+1] = max;
                }

        }
    }
    return mtrx;
}

System.Console.WriteLine("Введите размеры матрицы!");
System.Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Fillmatrix(n,m);
PrintMatrix(matrix);

System.Console.WriteLine();
matrix = Streamline(matrix);
PrintMatrix(matrix);






