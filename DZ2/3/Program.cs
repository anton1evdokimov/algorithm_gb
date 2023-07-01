int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool checkNumber(int num)
{
    return (num > 0 && num < 8);
}


int num = ReadNumber("Input number of week day > ");

if (checkNumber(num))
{
    string result = num > 5 ? "да" : "нет";
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Invalid number!");
}