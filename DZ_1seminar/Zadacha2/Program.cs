Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a < b)// при выполнении условия непонятный вывод итогов. 
//При не выполнении условия, вывод корректный. В чем дело выяснить не получилось
{
    Console.WriteLine("Наибольшее число " + b);
    Console.WriteLine("Наименьшее число " + a);
}
else
    Console.WriteLine("Наибольшее число " + a);
    Console.WriteLine("Наименьшее число " + b);