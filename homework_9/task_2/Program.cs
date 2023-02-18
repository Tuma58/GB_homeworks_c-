/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/



int summa (int N,int M)
{ 
    if (N==M) 
    {
        return N;
    }
    else
    {
        if (N<M)
        {
            return N+summa (N+1,M);
        }
        else 
        {
            return M+summa (N,M+1);
        }
        
    }
}

Console.WriteLine ("Введите N и M ");
int N=Convert.ToInt32(Console.ReadLine());
int M=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(summa(N,M));