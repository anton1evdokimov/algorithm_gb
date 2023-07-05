// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int getSum(int num)
{
    var sum = 0;
    var str = num.ToString();
    for (var i = 0; i < str.Length; i++)
    {
        sum += Convert.ToInt16(str[i]) - 48;
    }
    return sum;
}

var num = ReadNumber("Input number > ");

Console.WriteLine($"Sum: {getSum(num)}");
