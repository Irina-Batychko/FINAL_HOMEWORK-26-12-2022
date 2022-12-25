/* Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

string[] arrayA = new string[5] { "Hello", "1", "2", "3", "world" };
string[] arrayB = new string[arrayA.Length];

void SecondArray(string[] arrayA, string[] arrayB)
{
    int values = 3;
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= values)
            arrayB[count++] = arrayA[i];
    }
}
void PrintArray1(string[] array)
{
    for (int index = 0; index < array.Length; index++)
        continue;
    Console.Write("[" + String.Join(", ", array) + "] -> ");
}
void PrintArray2(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrayA, arrayB);
PrintArray1(arrayA);
PrintArray2(arrayB);
