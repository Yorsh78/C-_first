int rand = new Random().Next(100,1000);
Console.WriteLine("Рандомное число - " + rand);
int y = FirstNumber(rand);
int FirstNumber(int x)
{
    int a = x/100;
    int b = x%10;
    x = a*10+b;
    return x;
}
Console.WriteLine("Удаляем среднюю цифру, получаем "+ y);