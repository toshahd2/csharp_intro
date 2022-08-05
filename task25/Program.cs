Console.Write("Введите число A, которое будет возводиться в степень: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B, которое будет степенью числа A: ");
int num_b = Convert.ToInt32(Console.ReadLine());
int result = num_a;

for (int i = 2; i < (num_b + 1); i++)
{
    result = result * num_a;
}

Console.WriteLine ($"{num_a} в степени {num_b} будет равно {result}");