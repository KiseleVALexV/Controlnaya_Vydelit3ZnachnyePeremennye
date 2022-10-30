// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше,
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] -> [":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string str;
int count = 0; 
string[] ArrStr = new string[count]; 
string[] ArrStr2 = new string[count];
string[] ArrResult = new string[count];

Console.WriteLine("Введите строки : ");
do
{
    str = Console.ReadLine();
    if (str!="")
    {
        count++;
        ArrStr2 = new string[count];

        for (int i = 0; i < ArrStr2.Length - 1; i++)
        ArrStr2[i] = ArrStr[i];

        ArrStr2[count - 1] = str;
        ArrStr = ArrStr2;
    }
} while (str != "");