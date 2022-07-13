Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int result = (num / 10) % 10;
    Console.WriteLine("Вторая цифра числа " + num + " - " + result);
}
else Console.WriteLine("Вы ввели не трёхзначное число");