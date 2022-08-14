Random random = new Random();
int rows = random.Next(3,10);
int columns = random.Next(3,10);
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
PrintElement(array);

void FillArray (int[,] array, int startNumber = -10, int finishNumber = 10)
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
}

void PrintElement(int[,] array)
{
    Console.WriteLine("Введите позиции элемента в двумерном массиве [i, j]:");
    Console.Write("i = ");
    int arrayI = Convert.ToInt32(Console.ReadLine());
    Console.Write("j = ");
    int arrayJ = Convert.ToInt32(Console.ReadLine());
    if (arrayI < array.GetLength(0) && arrayJ < array.GetLength(1)) 
    {
    Console.WriteLine($"array[{arrayI}, {arrayJ}] = {array[arrayI, arrayJ]}");
    }
    else Console.WriteLine("Такого элемента нет в массиве");
}