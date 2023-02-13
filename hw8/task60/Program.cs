Console.Clear();

int[,,] Fillmatrix(int[] arr, int rows, int columns, int col)
{
    int[,,] mtrx = new int[rows,columns,col];
    {
        int count = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < col; k++)
                {
                    mtrx[i,j,k] = arr[count];
                    count++;
                }
            }
        }
    } 
    return mtrx;
}



void PrintMatrix(int[,,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            for (int j = 0; j < mtrx.GetLength(1); j++)
            {
                for (int k = 0; k < mtrx.GetLength(2); k++)
                {
                    System.Console.Write(mtrx[i,j,k]+ "(" + i + "," + j + "," + k + ")" + "\t");
                }
                System.Console.WriteLine();
            }
    }    
}


Random rand = new Random();
int[] RandomElem(int rows, int columns, int col) {
    int[] arr = new int[rows * columns * col];
    for (int i = 0; i < (rows * columns * col); i++)
    {
        arr[i] = rand.Next(10, 100);
        for (int j = 0; j < arr.Length; j++)
        {
            if (i != j)
            {
                while (arr[i] == arr[j])
                {
                    arr[i] = rand.Next(10, 100);                 
                }
            }
        }
    }
    return arr;
}



System.Console.WriteLine("Введите размеры  матрицы!");
System.Console.Write("Количество ячеек по оси Х: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество ячеек по оси Y: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество ячеек по оси Z: ");
int l = Convert.ToInt32(Console.ReadLine());


int[] array = RandomElem(n,m,l);
int[,,] matrix = Fillmatrix(array, n, m, l);
PrintMatrix(matrix);














