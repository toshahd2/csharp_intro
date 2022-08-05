int size = 8;
int[] array = new int[size];
int temp;

Console.Write("[ ");
for (int i = 0; i < size; i++)
{
    Random rand = new Random();
    temp = rand.Next(-9, 10);
    array[i] = temp;
    Console.Write($"{array[i]}, ");
}
Console.Write("\b\b ]");
Console.WriteLine();

for (int j = size - 1; j > 0 ; j--)
{
    for (int l = 0; l < j; l++)
    {
        
    
        if (Math.Abs(array[l]) > Math.Abs(array[l+1]) )
        {
            int temp2 = array[l];
            array[l] = array[l+1];
            array[l+1] = temp2;
        }
    }
}   

Console.Write("[ ");
for (int k = 0; k < size; k++)
{
    Console.Write($"{array[k]}, ");
}
Console.Write("\b\b ]");