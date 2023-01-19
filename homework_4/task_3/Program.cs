/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

static int[] massiv(int c)
        {
            int[] arr =new int[c];
            Random rnd = new Random();
            for (int i=0;i<=c-1;i++)
            {
                arr[i]=rnd.Next();
                //Console.WriteLine(arr[i]);
            }
            
            /*for(int i=0;i<=c-1;i++)   // поробуем вывести из функции в основное тело
            {
                Console.Write($"{arr[i]} ");
            } */
            return arr;
        }
       
Console.Write("Введите размерность массива "); // основоное тело программы
int a = Convert.ToInt32(Console.ReadLine());
int[] mass= new int[a];
mass=massiv(a);
foreach(int l in mass)
{
    Console.Write($"{l} ");
}

Console.ReadKey();