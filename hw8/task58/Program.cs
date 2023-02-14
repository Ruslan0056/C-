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
                mtrx[i,j] = rand.Next(1, 6);
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

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int k = 0;
            int l = 0;
            while (k < matrix1.GetLength(1) && l < matrix2.GetLength(0))
            {
                resultMatrix[i, j] += matrix1[i,k%(matrix1.GetLength(1))] * matrix2[l%(matrix2.GetLength(0)),j];
                k++;
                l++;
            }
        }
    }   
    return resultMatrix;
}

System.Console.WriteLine("Введите размеры первой матрицы!");
System.Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = Fillmatrix(n,m);
PrintMatrix(matrixA);

System.Console.WriteLine("Введите размеры второй матрицы!");
System.Console.Write("Количество строк: ");
int k = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int l = Convert.ToInt32(Console.ReadLine());

int[,] matrixB = Fillmatrix(k,l);
PrintMatrix(matrixB);

System.Console.WriteLine();
int[,] result = MultMatrix(matrixA, matrixB);
PrintMatrix(result);









