Console.Clear();
Console.Write("Введите количество месяцев: ");
int month = Convert.ToInt32(Console.ReadLine());
double sum = 1000;
for (int i = 0; i < (month); i++)
{
    sum = Math.Round(sum * 1.015, 2);
    Console.Clear();
    Console.WriteLine($"Баланс депозита по итогу {month} месяцев(-ца): {sum} рублей");
}