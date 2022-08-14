Random random = new Random();
int rows = random.Next(3,10);
int columns = random.Next(3,10);
double[,] array = new double[rows, columns];
FillArray(array, -100, 100);
PrintArray(array);

void FillArray (double[,] array, int startNumber = -50, int finishNumber = 50)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(startNumber, finishNumber) + Math.Round(rand.NextDouble(), 1);
        }
    }
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}