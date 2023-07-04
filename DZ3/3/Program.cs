// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

var num = ReadNumber("Input number > ");

var current = 1;

while (current <= num)
{
    if (current > 1)
    {
        Console.Write(", ");
    }
    Console.Write(Math.Pow(current, 3));
    current++;
}