Console.Clear();
Console.Write("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 0 && day < 6) Console.WriteLine("Будний день");
else if(day > 5 && day < 8) Console.WriteLine("Выходной день");
else Console.WriteLine("Нет такого дня недели");