﻿// Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

Console.WriteLine("Введите строку, содержащую латинские буквы в обоих регистрах: ");
string text = Console.ReadLine();
Console.WriteLine(text.ToLower());