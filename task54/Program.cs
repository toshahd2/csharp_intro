Random random = new Random();
int rows = random.Next(4,10);
int columns = random.Next(4,10);
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
SortArray(array);
PrintArray(array);

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


void SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int lastElementRow= array.GetLength(1) - 1;

    for (int i = 0; i < rows; i++)
    {
        for (int k = lastElementRow; k > 0; k--)
        {
            for (int j = 0; j < k; j++)
            {
                if (array[i, j] < array[i, j+1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j+1];
                    array[i, j+1] = temp;
                }
            }
        }
    }
}