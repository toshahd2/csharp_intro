Console.Clear();
Console.Write("Введите длину стороны a: ");
int sidea = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину стороны b: ");
int sideb = Convert.ToInt32(Console.ReadLine());
int temp_max = sidea + sideb;
int temp_min = 0;
int temp_min1 = sideb - sidea;
int temp_min2 = sidea - sideb;
if(temp_min1 > temp_min) temp_min = temp_min1;
if(temp_min2 > temp_min) temp_min = temp_min2;
Console.Write("Для существования треугольника с должно быть больше "+ temp_min + " и меньше " + temp_max + ". Введите длину стороны c: ");
int sidec = Convert.ToInt32(Console.ReadLine());
if (sidea + sideb > sidec && sidea + sidec > sideb && sideb + sidec > sidea && sidea > 0 && sideb > 0 && sidec > 0)
{
    if(sidea == sideb || sidea == sidec || sideb == sidec) Console.WriteLine("Треугольник равнобедренный");
    else Console.WriteLine("Треугольник неравнобедренный");
}
else Console.WriteLine("При данных длинах сторон треугольник не может существовать");