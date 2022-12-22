// выводим все четные числа с 0 до N 
Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=0;i<=n;i++)
{
    if (i%2==0)
    {
        Console.Write($" {i},");
    }
}
Console.ReadKey();

