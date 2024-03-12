
using System;
class Program
{
// метод печати массива
     public static void PrintArray(string[] array)
        {
         Console.WriteLine(string.Join(", ", array));
        }
// метод фильтрации массива по колличеству символов
static string[] FilterArrayByLength(string[] inputArray)
    {
    int count = 0;

        foreach (string item in inputArray)
        {
            if (item.Length <= 3) count++;
            
        }
        string[] resultArray = new string[count];

    int index = 0;

        foreach (string item in inputArray)
        {
            if (item.Length <= 3)
            {
                resultArray[index] = item;
                index++;
            }
        }
        return resultArray;
    }

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