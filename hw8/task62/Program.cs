Console.Clear();

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


int[,] FillSpiral(int rows, int cols, int startNumber)
{
    int[,] spiralArray = new int[rows, cols];
    int count = startNumber;
    int startCol = 0;
    int endCol = cols - 1;
    int startRow = 0;
    int endRow = rows - 1;
        

    while (count - startNumber < rows * cols)    
    {
        for (int i = startCol; i <= endCol; i++)
        {
            spiralArray[startRow,i] = count;
            count++;
        }
        startRow++;

        if (count - startNumber >= rows * cols) {
            break;
        }

        for (int i = startRow; i <= endRow; i++)
        {
            spiralArray[i,endCol] = count;
            count++;
        }
        endCol--;

        if (count - startNumber >= rows * cols) {
            break;
        }

        for (int i = endCol; i >= startCol; i--)
        {
            spiralArray[endRow,i] = count;
            count++;
        }
        endRow--;

        if (count - startNumber >= rows * cols) {
            break;
        }

        for (int i = endRow; i >= startRow; i--)
        {
            spiralArray[i,startCol] = count;
            count++;
        }
        startCol++;

    }
    return spiralArray;
}





System.Console.WriteLine("Введите размеры первой матрицы!");
System.Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите стартовое число: ");

int number = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillSpiral(n,m, number);
PrintMatrix(matrix);










