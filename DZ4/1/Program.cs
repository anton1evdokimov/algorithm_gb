// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Сделать через функции
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double RaiseNumberToPower(int num, int pow)
{
    return Math.Pow(num, pow);
}

while (true)
{
    var A = ReadNumber("Input A > ");
    var B = ReadNumber("Input B > ");
    Console.WriteLine($"Result: {RaiseNumberToPower(A, B)}");
}
