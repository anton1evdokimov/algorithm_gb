using System;

int ReadNumber(string msg)
{
    Console.Write(msg);
    var inputedStr = Console.ReadLine();
    return Convert.ToInt32(inputedStr);
}

void Task3()
{
    Console.WriteLine("Start task3: ");
    int num = ReadNumber("Input number > ");
    Console.WriteLine(num % 2 == 0 ? "да" : "нет");
    Console.WriteLine("");
}

Task3();