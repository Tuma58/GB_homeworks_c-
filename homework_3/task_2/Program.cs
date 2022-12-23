/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int InputPoint (out int x, out int y, out int z)
{
    Console.Write("X: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Z: ");
    z = Convert.ToInt32(Console.ReadLine()); 
    return x;  
    return y;
    return z;
}
double Dist (int x1,int y1, int z1, int x2, int y2, int z2)
{
    double Distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
    return Distance;
}

int x1,x2,y1,y2,z1,z2;
Console.WriteLine("Введите координыты первой точки:");
InputPoint(out x1,out y1,out z1);
Console.WriteLine("Введите координыты второй точки:");
InputPoint(out x2,out y2,out z2);
Console.WriteLine($"Расстояние между точками: {Dist(x1,y1,z1,x2,y2,z2)}");
Console.ReadKey();

