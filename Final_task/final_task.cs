string [] CreateArrayByUser(int size)
{
    string[] arr = new string [size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива");
        arr[i]= Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]:F2}, ");
        else Console.Write($"{array[i]:F2}");
    }
    Console.Write("]");
}