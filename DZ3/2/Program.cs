// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

var x1 = ReadNumber("Input x1 > ");
var y1 = ReadNumber("Input y1 > ");
var z1 = ReadNumber("Input z1 > ");

var x2 = ReadNumber("Input x2 > ");
var y2 = ReadNumber("Input y2 > ");
var z2 = ReadNumber("Input z2 > ");

var distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"The distance is {distance}");