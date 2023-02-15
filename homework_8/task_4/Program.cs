/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

static int[,,] massiv(int c, int d, int f)
        {
            Console.WriteLine($"Генерация массива А[{c},{d},{f}]");
            int[,,] arr =new int[c,d,f];
            Random rnd = new Random();
            for (int i=0;i<=c-1;i++)
            {
                for (int j=0;j<=d-1;j++)
                    {
                        for (int k=0;k<=f-1;k++)
                            {
                                arr[i,j,k]=rnd.Next(100);
                            }
                        
                    }
                
            }         
            Console.WriteLine("Массив сгенерирован");             
            return arr;
        }

void out_massive_3(int[,,]a)
{
        for (int i=0;i<=a.GetLength(0)-1;i++)
            {
                for (int j=0;j<=a.GetLength(1)-1;j++)
                    {
                        for (int k=0;k<=a.GetLength(2)-1;k++)
                            {
                                Console.Write ($"Элемент[{i},{j},{k}] -> {a[i,j,k]} ");
                            }
                        Console.WriteLine();
                    }
                Console.WriteLine();
                Console.WriteLine();
            }         
            Console.WriteLine("Вывод массива завершен"); 
     
}


/* void prit_array (int[,]arr)
{
    for (int i=0;i>=arr.GetLength(0)-1;i++)
        {
            for (int j=0;j>=arr.GetLength(1)-1;j++)
                {
                    Console.Write(arr[i,j]);
                }
            Console.WriteLine();    
        }
} */


Console.Write ("!!!!!!!!!!!!!!!!!!!!!!");
Random rd =new Random();
out_massive_3(massiv(rd.Next(100),rd.Next(100),rd.Next(100)));