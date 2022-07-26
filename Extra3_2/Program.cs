// Дано трёхзначное число N.
// Определить кратна ли трём сумма всех его цифр.
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
int sum = first + second + third;
int modulo = sum % 3;
if (modulo == 0)
{
    Console.WriteLine($"Сумма чисел равна {sum} и кратна трём");
}
else Console.WriteLine($"Сумма чисел равна {sum} и НЕ кратна трём");