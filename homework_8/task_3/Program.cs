/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

static int[,] massiv(int c, int d)
        {
            Console.WriteLine($"Генерация массива А[{c},{d}]");
            int[,] arr =new int[c,d];
            Random rnd = new Random();
            for (int i=0;i<=c-1;i++)
            {
                for (int j=0;j<=d-1;j++)
                    {
                        arr[i,j]=rnd.Next(100);
                    }
                
            }         
            Console.WriteLine("Массив сгенерирован");             
             return arr;
        }

static int[,] umnogenie(int[,]a ,int[,]b)
{
int[,] c=new int[b.GetLength(0),a.GetLength(1)];
    
if (a.GetLength(1)==b.GetLength(0))
{
    Console.WriteLine("Матрицы совместивы");   

    for (int i=0;i<=c.GetLength(0)-1;i++)
        {   
            
            for (int j=0;j<=c.GetLength(1)-1;j++)
                {
                    
                    //for (int k=0;k<=b.GetLength(0);k++)
                      //  {

                            c[i,j]=c[i,j]+a[i,j]*b[j,i];
                            Console.Write ($"C[{i},{j}] {c[i,j]} ");
                       // }
                }
                Console.WriteLine();
        }

}
else 
{
    Console.WriteLine("матрицы не согласованны, перемножение без доп преобразований невозможно");
}
return c;         
}


void prit_array (int[,]arr)
{
    Console.WriteLine("Вывод матрицы");
    for (int i=0;i<=arr.GetLength(0)-1;i++)
        {
            for (int j=0;j<=arr.GetLength(1)-1;j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
            Console.WriteLine();    
        }
}


Console.Write ("Введите размерность матрицы, для упрощения будем применять квадратные матрицы ");
int razm = Convert.ToInt32(Console.ReadLine());
prit_array(umnogenie(massiv(razm,razm),massiv(razm,razm)));