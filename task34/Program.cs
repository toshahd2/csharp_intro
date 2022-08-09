Random rand = new Random();
int size = rand.Next(6, 10);
int[] array = new int[size];
FillArray(array);
PrintArray(array);
CountPositive(array);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 1000);
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

void CountPositive(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }

    Console.WriteLine($"Количество чётных чисел в массиве равно {count}");
}