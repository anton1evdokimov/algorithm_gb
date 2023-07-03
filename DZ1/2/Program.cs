using System;

int ReadNumber(string msg)
{
    Console.Write(msg);
    var inputedStr = Console.ReadLine();
    return Convert.ToInt32(inputedStr);
}

void Task2()
{
    Console.WriteLine("Start task2: ");

    int num1 = ReadNumber("Input first number > ");
    int num2 = ReadNumber("Input second number > ");
    int num3 = ReadNumber("Input third number > ");

    int result = num1;

    if (num2 > result)
    {
        result = num2;
    }
    if (num3 > result)
    {
        result = num3;
    }

    Console.WriteLine($"Максимальное число: max={result}");
    Console.WriteLine("");
}

Task2();
