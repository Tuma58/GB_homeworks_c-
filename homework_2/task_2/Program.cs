/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int Razrjadnost (int InputNumber) // определение разрядности числа
{
   int razr =1; int ostatok = InputNumber/10;
   while (ostatok>10)
   {
   // Console.WriteLine($"Разрядность {razr} Остаток {ostatok}");
    razr++;
    ostatok=ostatok/10;
   }     
   return razr+1;
}

int NumNamberThree (int InputNumber,int razrjad) // поиск 3 числа
{
  int number = Convert.ToInt32((InputNumber % Math.Pow(10,razrjad-2))/Math.Pow(10,razrjad-3)); //есть косяк проявляется с разрядностью выше 7
  return number;
}

// основное тело программы

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
if (Razrjadnost(num)<3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine ($"Разрядность {Razrjadnost(num)}");    
Console.WriteLine ($"Третья цифра равна {NumNamberThree(num,Razrjadnost(num))}");
}
Console.ReadKey();
