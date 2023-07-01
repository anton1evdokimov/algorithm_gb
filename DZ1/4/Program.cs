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

    var result = new List<int>();
    for (var i = 1; i <= num; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("Add");
            result.Add(i);
        }
    }

    Console.WriteLine(string.Join(", ", result.ToArray()));
}

Task4();