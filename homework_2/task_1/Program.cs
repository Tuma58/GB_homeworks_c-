// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int NumberNumTwo (int InputNumber)
{
  int number = (InputNumber % 100)/10;
  return number;
}
Console.Write("Введите 3х значное число: ");
Console.WriteLine($"Вторая цифра равна {NumberNumTwo(Convert.ToInt32(Console.ReadLine()))}");
Console.ReadKey();
