Random rand = new Random();
int size = rand.Next(6, 10);
double[] array = new double[size];
FillArray(array);
PrintArray(array);
SubMaxMin(array);

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 3) + Math.Round(rand.NextDouble(), 2);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SubMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    double sub = max - min;

    Console.WriteLine($"Разницу между максимальным и минимальным элементами массива равна {sub}");
}