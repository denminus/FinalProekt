// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array = new string[4] { "hello", "2", "world", ":-)" };
int len =Array.Length;
string[] NewArray = new string[len];
int index = 0;
for (int i = 0; i < len; i++)
{   int len2=Array[i].Length;
    if (len2 <= 3)
    {
        NewArray[index] = Array[i];
        index++;
    }
}
for (int k = 0; k < NewArray.Length; k++)
{
    Console.Write($"{NewArray[k]} ");
}
Console.WriteLine();
