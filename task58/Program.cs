int rows = 4;
int columns = 4;
int[,] array = new int[rows, columns];
int rowPosition = 0;
int columnPosition = 0;
int rowChange = 0;
int columnChange = 1;
int step = columns;
int turn = 0;

for (int i = 0; i < array.Length; i++)
{
    array[rowPosition, columnPosition] = i + 1;
    step--;
    if (step == 0)
    {
        step = rows - 1 - turn/2;
        int temp = rowChange;
        rowChange = columnChange;
        columnChange = -temp;
        turn++;
    }
    rowPosition += rowChange;
    columnPosition += columnChange;
}

PrintArray(array);

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
