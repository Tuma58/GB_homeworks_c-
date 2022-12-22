// Опреденение четности вводимого целого числа.

Console.Write("Введите цеое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("Введенное число четное! ");
} 
else
{
    Console.WriteLine("Введенное число не четное!");
}
Console.ReadKey();