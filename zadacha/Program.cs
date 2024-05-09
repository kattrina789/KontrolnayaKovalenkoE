/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
string[] stringArray = { "1234", "1567", "-2", "computer science" };
string[] CreateNewArray(string[] array)
{
    int count = 0;
    foreach (string s in array)
    {
        if (s.Length <= 3)
        {
            count = count + 1;
        }
    }
    string[] NewArray = new string[count];
    int index = 0;
    foreach (string s in array)
    {
        if (s.Length <= 3)
        {
            NewArray[index] = s;
            index = index + 1;
        }
    }
    foreach (string s in NewArray)
    {
        System.Console.Write(s + " ");
    }
    return NewArray;
}
string[] newArray = CreateNewArray(stringArray);
