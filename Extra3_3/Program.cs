// Дано трёхзначное число N.
// Определить, есть ли среди его цифр 4 или 7.

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num < 100 || num > 999)
{
    Console.Write("Вы ввели не трехзначное число, повторите ввод: ");
    num = Convert.ToInt32(Console.ReadLine());
}

int first = num / 100;
int second = (num / 10) % 10;
int third = num % 10;

if (first == 4 || second == 4 || third == 4)
{
    Console.WriteLine("В числе имеется цифра 4");
}
if (first == 7 || second == 7 || third == 7)
{
    Console.WriteLine("В числе имеется цифра 7");
}
if (first != 7 && first != 4 && second != 7 && second != 4 && third != 7 && third != 4)
{
    Console.WriteLine("В числе нет цифр 4 и 7");
}