Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if (a < c)
if (b < c)
{
    Console.WriteLine("Наибольшее число " + c);
}
if (c < b)
if (a < b)
{
    Console.WriteLine("Наибольшее число " + b);
}
if (b < a)
if (c < a)
{
    Console.WriteLine("Наибольшее число " + a);
}