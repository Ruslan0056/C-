Console.Clear();

Random rand = new Random();
double[,] Fillmatrix(int rows, int columns)
{
    double[,] mtrx = new double[rows,columns];
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                mtrx[i,j] = Math.Round(rand.Next(-10, 11) + rand.NextDouble(), 1);
            }
        }
    } 
    return mtrx;
}

void PrintMatrix(double[,] mtrx)
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

System.Console.WriteLine("Введите размеры матрицы!");
System.Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

double[,] matrix = Fillmatrix(n,m);
PrintMatrix(matrix);
