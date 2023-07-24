// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7->такого числа в массиве нет
// 1,2 -> 4
int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateArray(int col, int row)
{
    int[,] result = new int[col, row];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(-10, 10);
        }
    }

    return result;
}

int row = ReadNumber("Введтите номер строки массива: ");
int col = ReadNumber("Введтите номер столбца массива: ");

int[,] arr = GenerateArray(100, 100);


try
{
    Console.Write(arr[row, col]);
}
catch (IndexOutOfRangeException)
{
    Console.Write("Tакого числа в массиве нет");
}