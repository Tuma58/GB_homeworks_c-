/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int turn (int InNum) // перевораичваем 2х значное число
{
  int res = (InNum%10)*10+((InNum%100)/10);
  return res;
}

int pars (int InNum, out int num1, out int num2) // парсим 5 значное число рубим 2 последни (num2) и 2 первых цифры (num1)
{
    num1=(InNum%100000)/1000;
    num2=InNum%100;
    return num1;
    return num2;

} 


Console.Write("Введите 5ти значное число: "); // основоное тело программы
int num = Convert.ToInt32(Console.ReadLine());
int n1;
int n2;
pars(num,out n1,out n2);
// Console.WriteLine($"{n1}-{n2}");
if (turn(n1)==n2)
{
    Console.WriteLine($"число {num} является палиндромом");
}
else
{
    Console.WriteLine($"число {num}  не является палиндромом");
};
Console.ReadKey();


