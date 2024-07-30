// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
void Main()
{
    string[] array = {"dhh", "4$", "hello", "world", "bt6"};
    string[] array2 = new string[array.Length];
    PrintArray(array, array2);
}

void PrintArray(string[] arr, string[] arr2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
            arr2[i] = arr[i];

            System.Console.Write(arr2[i] + " ");

    }
}


Main();