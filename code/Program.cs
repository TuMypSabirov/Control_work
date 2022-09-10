// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void NoMoreThanThree(string[] startArray, string[] finishArray)
{
    int k = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= 3)
        {
            finishArray[k] = startArray[i];
            k++;
        }
    }
}

string[] startArray = new string[] { "sofa", "the", "table", "a", "is" };
string[] finishArray = new string[startArray.Length];

NoMoreThanThree(startArray, finishArray);
PrintArray(finishArray);