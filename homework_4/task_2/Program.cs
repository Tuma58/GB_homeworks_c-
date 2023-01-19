/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

static void summ(int c)
        {
            int p=c;
            int sum=0;
            while (p%10>0)
            {
                sum=sum+p%10;
                p=p/10;
            
            }
            
            Console.WriteLine($"сумма цифр числа {c}  равно {sum}");
        }
       
Console.Write("Введите число "); // основоное тело программы
int a = Convert.ToInt32(Console.ReadLine());

summ(a);

Console.ReadKey();


