using System;

int ReadNumber(string msg)
{
    Console.Write(msg);
    var inputedStr = Console.ReadLine();
    return Convert.ToInt32(inputedStr);
}

void Task1()
{
    Console.WriteLine("Start task1: ");

    int firstNum = ReadNumber("Input first number > ");
    int secondNum = ReadNumber("Input second number > ");

    int result = firstNum > secondNum ? firstNum : secondNum;

    Console.WriteLine($"Максимальное число: max={result}");
    Console.WriteLine("");
}

Task1();
