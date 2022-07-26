Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
double y = 0;
if (x > 0)
{
    y = Math.Pow(Math.Sin(x), 2);
    Console.WriteLine("y = Math.Pow(Math.Sin(x), 2)");
}
else y = 1 - (2 * Math.Sin(Math.Pow(x, 2)));
Console.WriteLine(y);