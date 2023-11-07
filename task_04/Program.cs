// Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.


Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами: ");
string text = Console.ReadLine();

string[] strArray = text.Split(" ");
string[] strArrayReturn = new string[strArray.Length];
for (int i = 0; i < strArray.Length; i++)
{
    strArrayReturn[i] = strArray[strArray.Length - 1 - i];
}

Console.WriteLine(String.Join(" ", strArrayReturn));

