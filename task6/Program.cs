Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int modulo = num % 2;
if (modulo == 0)
{
    Console.WriteLine("Число " + num + " чётное");
}
else
{
    Console.WriteLine("Число " + num + " нечётное");
}