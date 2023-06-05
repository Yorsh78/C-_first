Console.WriteLine("Введите любое первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите любое второе число");
int b = int.Parse(Console.ReadLine());
if (a%b == 0)
    Console.WriteLine("Числа кратны, поздравляю!");
else
    Console.WriteLine("Числа не кратны, соболезную, остаток " + a%b);