Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int start = -number;
while (start <= number)
{
    Console.Write(start + " ");
    start++;
}