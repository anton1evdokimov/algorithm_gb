int[] CreateArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(minValue, maxValue);

    return array;
}
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
    Console.WriteLine(']');
}
int length = ReadNumber("Введтите длину массива: ");

var arr = CreateArray(length, -100, 100);

int CalcResult(int[] arr)
{
    var result = 0;
    for (var i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += arr[i];
        }
    }
    return result;
}

PrintArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {CalcResult(arr)}");