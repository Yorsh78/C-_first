// Напишите программу, которая на вход принимает два числа А и Б, 
// и производит число А в целую степень числа Б с помощью рекурсии.
// А = 3, Б = 5, получаем 243 (А в степени Б)
// А = 2, Б = 3, получаем 8 (А в степени Б)

Console.Write(PowerRecV2(6, 2));

/*int PowerRec(int y, int x);
{
    return x==0  ? 1 : PowerRec(y, x - 1) * y;
    if (x == 0) return 1;
    else return PowerRec(y, x - 1) * y;
}*/

int PowerRecV2 (int numy, int numx)
{
    if (numx == 0) return 1;
    else return PowerRecV2(numy, numx - 1) * numy;
}
Console.WriteLine(" ");