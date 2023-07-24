// Задача 1. Задайте двумерный массив размером m×n, 
int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    Console.WriteLine('[');
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write('[');
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j != array.GetLength(1) - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine(']');
            }
        }
    }
    Console.WriteLine(']');
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

int row = ReadNumber("Введтите число строк массива: ");
int col = ReadNumber("Введтите число столбцов массива: ");

PrintArray(GenerateArray(row, col));// заполненный случайными вещественными числами.





