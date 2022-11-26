/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] CreateArray()
{
    Console.Write("Input array size: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    Console.Write("Create a new array");

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input array element {i + 1}: ");
        array[i] = Console.ReadLine();
    }
    Console.Write("Your array: ");
    return array;
}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] userArray = CreateArray();
ShowArray(userArray);





