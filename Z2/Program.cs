// a = любое число, b = любое число, необходимо указать, какое из них больше

Console.Clear();
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
 Console.WriteLine(a + " больше " + b);
}
else if (b > a)
{
 Console.WriteLine(b + " больше " + a);
}
else
{
 Console.WriteLine(b + " равно " + a);
}