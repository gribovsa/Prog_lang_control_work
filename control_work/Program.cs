// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// int[] NewArray(int countOfElem)
// {
//     int[] newArray = new int[countOfElem];
//     Random rnd1 = new Random();
//     for (int i = 0; i < countOfElem; i++)
//     {
//         newArray[i] = rnd1.Next(1, 100);
//     }
//     return newArray;
// }

// int[] array = new int[] { -5, -4, -3, -4, -1, 0, 1, 7, 8, 9 };
// foreach (int item in array)
// {
//     Console.Write($"{item * (-1)}");

// }

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


string[] inputArray = new string[] { "Hello", "2", "world", ":-)" };
PrintArray(inputArray);





// for (int i = 0; i < inputArray.Length; i++)
// {

//     Console.Write($"{inputArray[i]} ");
// }