// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

int[] ArrayDimension()
{
    int[] array = new int[2];
    Console.WriteLine("Введите колличество строк и столбцов в массиве через пробел: ");
    string[] strArray = Console.ReadLine().Split(" ");
    for (int i = 0; i < 2; i++)
    {
        array[i] = Convert.ToInt32(strArray[i]);
    }
    return array;

}

char[,] Array2DChar(int numLine, int numCol)
{
    char[,] strArray = new char[numLine, numCol];
    for (int i = 0; i < numLine; i++)
    {
        Console.WriteLine($"Введите {numCol} элементов {i + 1}-ой строки: ");
        string line = Console.ReadLine();
        char[] lineArrayChar = line.ToCharArray();

        for (int j = 0; j < lineArrayChar.Length; j++)
        {
            strArray[i, j] = lineArrayChar[j];
        }
    }
    return strArray;
}

void PrintArray2DChar(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

string Array2DTo1D(char[,] array2D)
{
    char[] strArray = new char[array2D.GetLength(0) * array2D.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            strArray[index] = array2D[i, j];
            // Console.Write(strArray[index] + " ");
            index++;
        }
    }   
    string array = String.Join("", strArray);
    return array; 
}


int[] dimantions = ArrayDimension();
char[,] arra2D = Array2DChar(dimantions[0], dimantions[1]);
// PrintArray2DChar(arra2D);
Console.WriteLine(Array2DTo1D(arra2D));




