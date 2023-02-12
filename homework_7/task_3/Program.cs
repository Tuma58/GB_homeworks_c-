/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
       
/*Console.WriteLine("Введите адрес элемента A[a,b] "); // основоное тело программы
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());*/
Random rnd = new Random();
int[,] mass=massiv(rnd.Next(1,15),rnd.Next(1,15));
/*if (a<=mass.GetLength(0)&(b<=mass.GetLength(1)))
{
    Console.WriteLine($"значение искомого элемента А[{a},{b}] равно {mass[a,b]}");
}
else
{
    Console.WriteLine($"элемента А[{a},{b}] не существует");
}*/
int s=0;
double sr=0;

for (int i=0;i<=mass.GetLength(0)-1;i++)
            {
                for (int j=0;j<=mass.GetLength(1)-1;j++)
                    {
                        Console.Write($"{mass[i,j]} ");

                    }
                Console.WriteLine();    
                
            }              

for (int i=0;i<=mass.GetLength(1)-1;i++)
            {
                for (int j=0;j<=mass.GetLength(0)-1;j++)
                    {
                        s=s+mass[j,i];    
                    } 
                sr = s/mass.GetLength(0);                   
                Console.WriteLine($" Среднеарифметическое столбца {i} равно {sr:0.00}");
                s=0;    
                
            }              

Console.ReadKey();