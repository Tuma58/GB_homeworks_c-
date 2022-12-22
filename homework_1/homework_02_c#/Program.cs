// Поиск больше числа из 3 введенных с клавиатуры
Console.WriteLine("Домашняя работа 1, поиск максимального из 3 введенных чисел");
Console.Write("Введите первое целое число : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторе целое число : ");
int b =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число : ");
int d =  Convert.ToInt32(Console.ReadLine());
if (a>b) 
{ 
    if (a>d) 
      {  
        Console.WriteLine ($"Первое число больше: {a}");
      }
    else  
      {
        Console.WriteLine ($"Третье число больше: {d}");  
      }  
}        
else 
{
    if (b>d)
       {
            Console.WriteLine ($"Второе число больше: {b}");
       }
    else 
       {
        Console.WriteLine ($"Третье число больше: {d}");
       }  
}
Console.ReadKey();
