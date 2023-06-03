Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());// что за команда такая, не знаю, подсмотрел. Голову ломал два часа, как решить
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.WriteLine(i + " ");
}