Console.WriteLine("¿Cual es el año?");
double a = double.Parse(Console.ReadLine());
double b = a / 4;
if (b != Math.Floor(b))
{
    Console.WriteLine("N");
}
else
{
    Console.WriteLine("S");
}