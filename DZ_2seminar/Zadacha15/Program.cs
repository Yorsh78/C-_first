// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Monday, не выходной");
}
if (number == 2)
{
    Console.WriteLine("Фторник, работай, солнце еще высоко");
}
if (number == 3)
{
    Console.WriteLine("Wednesday, до выходного рак на горе");
}
if (number == 4)
{
    Console.WriteLine("Все возможно четверг, выходной может быть после дождичка сегодня, но это не точно");
}
if (number == 5)
{
    Console.WriteLine("Пятница, ты близок к выходному как никогда, дружище");
}
if (number == 6)
{
    Console.WriteLine("Суббота, выходной!");
}
if (number == 7)
{
    Console.WriteLine("Воскресение, выходной");
}