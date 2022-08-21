﻿Random random = new Random();
int rows = random.Next(4,6);
int columns = random.Next(7,10);
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
MinRowSum(array);

void FillArray (int[,] array, int startNumber = 0, int finishNumber = 100)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(startNumber, finishNumber);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.WriteLine("Дан массив:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinRowSum(int[,] array)
{
    int size = array.GetLength(0);
    int[] minArray = new int[size];
    int rowSum;
    int length = array.GetLength(1);

    Console.Write("Сумма элементов строк массива составляет: ");
    for (int i = 0; i < size; i++)
    {
        rowSum = 0;
        for (int j = 0; j < length; j++)
        {
            rowSum += array[i, j];
        }
        minArray[i] = rowSum;
        Console.Write($"{minArray[i]} ");
    }
    Console.WriteLine();
    
    int min = minArray[0];
    int minIndex = 0;

    for (int k = 0; k < size; k++)
    {
        if (minArray[k] < min)
        {
            min = minArray[k];
            minIndex = k;
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов имеет индекс равный " + minIndex);
}