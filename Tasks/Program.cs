
using System;
class Program
{
static void Main()
    {

    string[] inputArray = { "Hello", "2", "world", ":-)","1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};

    string[] resultArray = FilterArrayByLength(inputArray);

    Console.WriteLine("Исходный массив:");
        PrintArray(inputArray);
    Console.WriteLine();

    Console.WriteLine("Новый массив (длина строк не более 3 символов):");
        PrintArray(resultArray);

    }   
}