int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

bool check3Digints(int num)
{
    return (num > 99 && num < 1000);
}


int num = ReadNumber("Input number > ");

if (check3Digints(num))
{
    string temp = num.ToString();
    Console.WriteLine($"Вторая цифра числа: {temp[1]}");
}

