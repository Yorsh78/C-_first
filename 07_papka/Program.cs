int rand = new Random().Next(100,1000);
Console.WriteLine("Рандомное число - " + rand);
int a = rand/100;
int b = rand%10;
rand = a*10+b;
Console.WriteLine("Удаляем среднюю цифру, получаем "+ rand);