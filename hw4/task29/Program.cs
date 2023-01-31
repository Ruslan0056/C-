Random rand = new Random();

int ArrayFilling() {

int[] array = new int[8]; 
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 50);
}
System.Console.WriteLine("[" + string.Join(", ", array) + "]");
return 0;
}

Console.Clear();

ArrayFilling();
