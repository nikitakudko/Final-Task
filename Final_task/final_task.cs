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

Console.WriteLine("Введите размер массива");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] arr = CreateArrayByUser(sizeArray);
PrintArray(arr);
int count = CountOfElem(arr);
Console.WriteLine();
PrintArray(ArrayWhithElemLessThanOrEqualThree(arr, count));