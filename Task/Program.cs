// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] NewStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string word = array[i];
        for (int j = 0; j < word.Length; j++)
        {
            if (j > 2)
            {
                array[i] = "";
            }
        }
    }
    return array;
}

void PrintNewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

string[] arr = { "Hello", "wor", ":-)", "-2" };
string[] result = NewStringArray(arr);
PrintNewArray(result);