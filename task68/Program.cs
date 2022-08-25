Console.Write("Введите первое неотрицательное число: ");
double m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
double n = Convert.ToInt32(Console.ReadLine());

double Recursion (double m, double n)
{
    if (m == 0) return n+1;
    else if((m > 0) && (n == 0)) return Recursion (m-1, 1);
    else return Recursion (m - 1, Recursion(m, n - 1));
}

Console.WriteLine(Recursion(m, n));

