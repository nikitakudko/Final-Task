string [] CreateArrayByUser()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string [size];
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите элемент массива(строка)");
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

int CountOfElem(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i].Length <= 3) count++;
    }
    return count; 
}

string [] ArrayWhithElemLessThanOrEqualThree (string[] array, int size)
{
    string[] newArr = new string[size];
    int j = 0;
    int i = 0;
    while(i < array.Length)
    {
    if (array[i].Length <= 3) 
        {
            newArr[j] = array[i];
            j++;
        }
    i++; 
    }
    return newArr;
}

string[] arr = CreateArrayByUser();
PrintArray(arr);
Console.WriteLine();
PrintArray(ArrayWhithElemLessThanOrEqualThree(arr, CountOfElem(arr)));