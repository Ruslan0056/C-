Console.Clear();

int SumElem(int m, int n)
{
    if (n >= m)
    {
        return n + SumElem(m, n - 1);
    }
    return 0;
}


System.Console.WriteLine(SumElem(1, 15));

System.Console.WriteLine(SumElem(4, 8));