Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите значение b2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if ( k1 - k2 == 0 ) Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * x) + b1;
    Console.WriteLine($"Точка пересечения двух прямых имеет координаты: {x}, {y}");
}