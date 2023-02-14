Console.Clear();

int Akkerman (int m, int n)
{
    
    if (m > 0 && n == 0) return Akkerman(m-1, 1);

    if (m > 0 && n > 0) return Akkerman(m-1, Akkerman(m, n-1));   

    return n + 1;
}

System.Console.WriteLine(Akkerman(2,3));

System.Console.WriteLine(Akkerman(3,2));

