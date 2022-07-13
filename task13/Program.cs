Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
if (num > 99)
{
    while (temp > 999)
    {
        temp = temp / 10;
    }
    int result = temp % 10;
    Console.WriteLine("Третья цифра числа " + num + " - " + result);
}
else Console.WriteLine("Третьей цифры нет");