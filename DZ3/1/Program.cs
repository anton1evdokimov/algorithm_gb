// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  Не использовать строки (только / и % используем)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool checkNumber(int num)
{
    return (num > 9999 && num < 100000);
}

int num = ReadNumber("Input number > ");

if (checkNumber(num))
{
    var result = "да";
    var temp1 = num / 10000;
    var temp2 = (num - temp1 * 10000) / 1000;
    var temp3 = num % 10;
    var temp4 = (num % 100 - temp3) / 10;
    if (temp1 != temp3 || temp2 != temp4)
    {
        result = "нет";
    }
    Console.WriteLine(result);
}
else Console.WriteLine("Error input!");

