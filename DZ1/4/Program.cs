using System;

int ReadNumber(string msg)
{
    Console.Write(msg);
    var inputedStr = Console.ReadLine();
    return Convert.ToInt32(inputedStr);
}

void Task4()
{
    Console.WriteLine("Start task4: ");
    int num = ReadNumber("Input first number > ");

    for (var i = 2; i <= num; i += 2)
    {
        Console.WriteLine(i);
    }

}

Task4();