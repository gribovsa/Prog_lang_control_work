// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


int LenNewArray(string[] arr)
{    //метод считает длинну нового массива из элементов менее 3 символов
    int lenNewArr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            lenNewArr++;
        }
    }
    return lenNewArr;

}

string[] NewArray(string[] arr, int lenNewArr) //метод созаёт новый массив из элементов старого
{
    string[] newArray = new string[lenNewArr]; //создаю новый пустой массив известной длинны
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) //при выполнении условия
        {
            newArray[j] = arr[i]; //заполняю его элементами
            j = j + 1;
            //newArray = newArray.Append(arr[i]).ToArray(); //возможен такой вариант
            //newArray = newArray.Concat(new string[] { arr[i] }).ToArray(); //возможен такой вариант
        }

    }
return newArray;
}

void ShowArray(string[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.WriteLine($"элемент: {arrayToShow[i]} ");
    }
}

string[] inputArray = new string[] { "Hello", "2", "world", ":-)" };
int len =  LenNewArray(inputArray);
string[]newArr = NewArray(inputArray, len);
Console.WriteLine("Старый массив");
ShowArray(inputArray);
Console.WriteLine("Новый массив");
ShowArray(newArr);

