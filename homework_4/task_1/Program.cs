/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

static void Stepen(int c,int d)
        {
            Console.WriteLine(d);
            int rez=1;
            for (int i=1;i<=d;i++)
            {
                rez=rez*c;
            }
            Console.WriteLine($"число {c} в степени {d} равно {rez}");
        }
       


Console.Write("Введите первое число "); // основоное тело программы
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Stepen(a,b);

Console.ReadKey();


