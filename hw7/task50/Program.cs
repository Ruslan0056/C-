﻿Console.Clear();

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

int[] EnterIndex() {
    int[] index = new int[2];
    System.Console.WriteLine("Введите индекс:");
    for (int i = 0; i < index.Length; i++)
    {
        index[i] = Convert.ToInt32(Console.ReadLine());
    }
    return index;
}


void SearchNumber(int[,] mtrx, int[] index)
{

    if (index[0] >= mtrx.GetLength(0) || index[1] >= mtrx.GetLength(1) )
    {
        System.Console.WriteLine("Такого числа нет!");
    }
    else
    {
    int number = mtrx[index[0], index[1]];
    System.Console.WriteLine($"Искомое число: {number}.");
    }
}

System.Console.WriteLine("Введите размеры матрицы!");
System.Console.Write("Количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = Fillmatrix(n,m);
PrintMatrix(matrix);

System.Console.WriteLine();

int[] index = EnterIndex();
SearchNumber(matrix, index);



