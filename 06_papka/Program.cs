Main();
void Main()
{
    int rand1 = new Random().Next(10,100);
    Console.WriteLine("Рандомное число - " + rand1);
    int a1 = FindFirstDigitNumber(rand1);// 1 цифра рандома
    int b1 = FindSecondDigitNumber(rand1);// последняя цифра рандома
    FindLargestNumber(a1, b1);
    int rand2 = new Random().Next(10,100);
    Console.WriteLine("Рандомное число - " + rand2);
    int a2 = FindFirstDigitNumber(rand2);// 1 цифра рандома
    int b2 = FindSecondDigitNumber(rand2);// последняя цифра рандома
    FindLargestNumber(a2, b2);
}

void FindLargestNumber(int a, int b)
{
        if (a > b)
    {
        Console.WriteLine("Наибольшая цифра числа = " + a);
    }
    else if (a < b)
    {
        Console.WriteLine("Наибольшая цифра числа = " + b);
    }
    else 
    {
        Console.WriteLine("Числа равны");
    }
}

int FindFirstDigitNumber(int r)
{
    int result = r/10;
    return result;
}

int FindSecondDigitNumber(int r)
{
    int result = r%10;
    return result;
}
