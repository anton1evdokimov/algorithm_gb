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

    int firstNum = ReadNumber("Input first number > ");
    int secondNum = ReadNumber("Input second number > ");
    int thirdNum = ReadNumber("Input third number > ");

    int result;
    if (firstNum > secondNum)
    {
        if (firstNum > thirdNum)
        {
            result = firstNum;
        }
        else
        {
            result = thirdNum;
        }
    }
    else
    {
        if (secondNum > thirdNum)
        {
            result = secondNum;
        }
        else
        {
            result = thirdNum;
        }
    }

    Console.WriteLine($"Максимальное число: max={result}");
    Console.WriteLine("");
}

Task2();
