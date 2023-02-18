/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


*/

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
     
    return Fibonachi(n - 1) + Fibonachi(n - 2);
}

int PrintNum (int N)
{ 
    if (N==1) 
    {
        Console.Write("1 |");
        return 1;
    }
    else
    {
        Console.Write($"{N} ");
        return N-PrintNum (N-1);
    }
}

Console.WriteLine ("Введите N ");
int N=Convert.ToInt32(Console.ReadLine());
//for (int i=0;i<=N;i++)
//{
//Console.Write($"{Fibonachi(i)} ");
//}
PrintNum(N);