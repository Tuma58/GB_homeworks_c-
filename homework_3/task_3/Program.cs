/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
double kub (double n) //возводим в куб
{
    double result = Math.Pow(n,3);
    return result;
}

Console.Write("Введите число: ");
double N = Convert.ToDouble(Console.ReadLine());
for (double i=1;i<=N;i++)
{
    Console.WriteLine($"Куб числа {i} равен {kub(i)}");
}
Console.ReadKey();
