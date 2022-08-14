Random random = new Random();
int rows = random.Next(4,10);
int columns = random.Next(4,10);
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
AverageColumns(array);

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
    Console.WriteLine("Данн массив: ");
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

void AverageColumns(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double avegareColumn = 0;
    double sum = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");

    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            sum = sum + array[i, j];
        }
        avegareColumn = Math.Round(sum / rows, 2);
        Console.Write(avegareColumn + ", ");
        avegareColumn = 0;
        sum = 0;
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}