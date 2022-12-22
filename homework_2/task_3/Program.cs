/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
bool CheckDay (int num)
{
    bool Weekend = (num >= 6);
    return Weekend;
     
}

Console.Write("Введите номер дня недели: ");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay<=7)
{
    Console.WriteLine($"Выходной? -> {CheckDay(numDay)}"); 
}
else 
{
   Console.WriteLine($"Ввели недопустимое значение!");  
}
