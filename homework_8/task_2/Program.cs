/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/


static int[,] massiv(int c, int d)
        {
            Console.WriteLine($"массив А[{c},{d}]");
            int[,] arr =new int[c,d];
            Random rnd = new Random();
            for (int i=0;i<=c-1;i++)
            {
                for (int j=0;j<=d-1;j++)
                    {
                        arr[i,j]=rnd.Next(100);

                    }
                
            }                      
             return arr;
        }
       
Random rnd = new Random();
int[,] mass=massiv(rnd.Next(1,15),rnd.Next(1,15));

int s=0;
int [] mass_s = new int[mass.GetLength(0)];

for (int i=0;i<=mass.GetLength(0)-1;i++)
            {
                for (int j=0;j<=mass.GetLength(1)-1;j++)
                    {
                        s=s+mass[i,j];
                        Console.Write($"{mass[i,j]} ");

                    }
                  
                   mass_s[i]=s;  
                   s=0;
                Console.WriteLine();    
                
            } 


int min_s=0;                       
min_s=mass_s[0];
int num_stroki=0;
for (int i=0;i<=mass_s.GetLength(0)-1;i++)
{
Console.Write ($"{mass_s[i]} ");
if (min_s>mass_s[i]) {min_s=mass_s[i];num_stroki=i;};
};
Console.WriteLine();
Console.WriteLine ($"{num_stroki} строка с минимаьной суммой элементов");
