//страница 16 номер 22
Console.WriteLine("Введите координату x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y");
double y = Convert.ToDouble(Console.ReadLine());
if (y >= 0 && x >= 4 && y <= -6 - x || y <= 0 && x <= -4 && y >= 0 - x)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}