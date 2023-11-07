// Задайте произвольную строку. Выясните,
// является ли она палиндромом.


Console.WriteLine("Введите произвольную строку: ");
string text = Console.ReadLine();


bool Polindrom(string text)
{
    for (int i = 0; i < text.Length / 2; i++)
    {
        if (text[i] != text[text.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

if (Polindrom(text))
{
    Console.WriteLine($"{text} => Yes");
}
else{
    Console.WriteLine($"{text} => No");
}