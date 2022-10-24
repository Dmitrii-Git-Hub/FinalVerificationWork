// Программа, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 

string[] FormArrayElements1To3Characters(string[] arr)
{
    //Количество элементов в новом массиве
    int number = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            number++;
        }
    }
    //Создаёт новый массив
    string[] newArr = new string[number];
    //Если есть строки, длина которых меньше, либо равна 3 символам, заполняет этими строками новый массив
    if (number > 0)
    {
        number = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[number] = arr[i];
                number++;
            }
        }
    }
    return newArr;
}
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write(arr[i]);//Последний элемент массива без зяпятой
        else Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

//Основной код программы
string[] array = new string[] { "Hello", "2", "world", ":-)" };
PrintArray(FormArrayElements1To3Characters(array));