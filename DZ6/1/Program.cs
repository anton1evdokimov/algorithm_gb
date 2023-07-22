// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int count = ReadNumber("Введтите число элеметов: ");

int result = 0;

for (int i = 1; i <= count; i++)
{
    if(ReadNumber($"Введтите число номер {i}: ")> 0)
    {
        result++;
    }
}

Console.WriteLine(result);