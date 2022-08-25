Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Recursion (int m, int n, int sum = 0)
{
    if(m > n) return sum;
    sum += m;
    m++;
    return Recursion (m, n, sum);
}

Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна {Recursion(m, n)}");