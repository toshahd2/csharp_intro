string dataInput;
int size = 100;
int[] array = new int[size];

Console.Write("Введите числа, для остановки ввода напишите end: ");

for (int i = 0; i < array.Length; i++)
{
    dataInput = Console.ReadLine();
    if (dataInput != "end") array[i] = Convert.ToInt32(dataInput);
    else break;
}

CountPositiveNumbers(array);

void CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"Вы ввели {count} чисел(числа) больше 0");
}