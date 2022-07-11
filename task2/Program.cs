Console.Write("Введите значение числа a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа b: ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) max = b;
Console.WriteLine("a = " + a + ", b = " + b + ", max = " + max);