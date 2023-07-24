// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CalcResult(int[,] array)
{
    int k = array.GetLength(0); // number of rows
    int[] result = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[j, i];
            if (j == array.GetLength(0) - 1)
            {
                result[i] /= k;
            }
        }
    }
    return result;
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
    Console.WriteLine(']');
}

int row = ReadNumber("Введтите число строк массива: ");
int col = ReadNumber("Введтите число столбцов массива: ");

int[,] array = GenerateArray(row, col);
PrintArray(CalcResult(array));