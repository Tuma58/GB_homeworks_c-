/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

double FAkerman(double m, double n)
{
    if (m == 0) return n + 1;
    else
    if (m>0&&n>0) return FAkerman (m-1,FAkerman(m,n-1));
    else return FAkerman (m-1,1);
}       

Console.WriteLine ("Введите N и M ");
double M=Convert.ToDouble(Console.ReadLine());
double N=Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine(FAkerman(M,N));