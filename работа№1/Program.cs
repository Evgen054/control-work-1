//  Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }

}

void PrintArray(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

}



string[] array1 = new string[5] { "123", "23", "hello", "world", "res" };
string[] array2 = new string[array1.Length];

SecondArrayWithIF(array1, array2);
Console.Write($"[");
PrintArray(array1);
Console.Write($"]");

Console.Write(" -> ");

Console.Write($"[");
PrintArray(array2);
Console.Write($"]");
