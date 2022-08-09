Random rand = new Random();
int size = rand.Next(6, 10);
int[] array = new int[size];
FillArray(array);
PrintArray(array);
SumOdd(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SumOdd(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }

    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
}