/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

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


for (int i=0;i<=mass.GetLength(0)-1;i++)
            {
                for (int j=0;j<=mass.GetLength(1)-1;j++)
                    {
                        Console.Write($"{mass[i,j]} ");

                    }
                Console.WriteLine();    
                
            }              
Console.WriteLine();
for (int i=0;i<=mass.GetLength(0)-1;i++)
            {
                for (int j=0;j<=mass.GetLength(1)-1;j++)
                    {
                        int temp_var=0;
                        int max=mass[i,j];
                        for (int k=j;k<=mass.GetLength(1)-1;k++)
                            {
                                if (mass[i,k]>max)
                                     {temp_var=k;max=mass[i,k];};
                            }   
                        mass[i,temp_var]=mass[i,j];    
                        mass[i,j]=max;   
                        Console.Write($"{mass[i,j]} "); 

                    } 
                    Console.WriteLine();
                
                                
            }              

Console.ReadKey();