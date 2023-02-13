/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

static double[,] massiv(int c, int d)
        {
            double[,] arr =new double[c,d];
            Random rnd = new Random();
            for (int i=0;i<=c-1;i++)
            {
                for (int j=0;j<=d-1;j++)
                    {
                        arr[i,j]=rnd.Next();

                    }
                
            }                      
             return arr;
        }
       
Console.WriteLine("Введите размерность массива [a,b] "); // основоное тело программы
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double[,] mass= new double[a,b];
mass=massiv(a,b);
for (int i=0;i<=a-1;i++)
            {
                for (int j=0;j<=b-1;j++)
                    {
                        Console.Write($"{mass[i,j]} ");

                    }
                Console.WriteLine();    
                
            }              

Console.ReadKey();