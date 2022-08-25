Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

string Recursion (int m, int n)
{
    if(m > n) return "Все значения выведены";
    if (m%3 == 0) Console.WriteLine(m);
    m++;
    return Recursion (m, n);
}

Console.WriteLine(Recursion(m, n));