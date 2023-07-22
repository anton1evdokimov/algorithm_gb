// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int b1 = ReadNumber("Введтите коэффициент b1: ");
int k1 = ReadNumber("Введтите коэффициент k1: ");
int b2 = ReadNumber("Введтите коэффициент b2: ");
int k2 = ReadNumber("Введтите коэффициент k2: ");

// k1* x + b1 = k2 * x + b2;

int deltaB = b2 - b1;

int x = deltaB == 0 ? 0 : (k1 - k2) / (b2 - b1);
int y = k1 * x + b1;

Console.WriteLine($"x = {x}; y = {y};");


