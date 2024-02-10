// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//string[] stringArray = new string[] {"Hello,", "world", "!", ":-)"};

string[] stringArray = new string[] {"1234", "56", "789", "10 11 12 13", "science"};
PrintArray(stringArray);
string[] resultArray = GetNewArray(stringArray);
Console.Write(" -> ");
PrintArray(resultArray);

string[] GetNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) count++;
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }    
    return result;
}

void PrintArray(string[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"'{arr[i]}', ");
    }
    Console.Write($"'{arr[arr.Length-1]}'"); 
    Console.Write("]");
}
