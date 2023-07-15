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

var arr = CreateArray(length, 100, 1000);

int CalcResult(int[] arr)
{
    var count = 0;
    for (var i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}

PrintArray(arr);
Console.WriteLine($"Количество четных чисел: {CalcResult(arr)}");