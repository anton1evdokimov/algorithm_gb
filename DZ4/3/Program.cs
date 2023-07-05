// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Сделать через функции
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write(']');
}

int[] CreateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(minValue, maxValue);

    return array;
}

int length = ReadNumber("Введтите длину массива: ");
int minValue = ReadNumber("Введтите минимальное значение массива: ");
int maxValue = ReadNumber("Введтите максимальное значение массива: ");

PrintArray(CreateArray(length, minValue, maxValue));

