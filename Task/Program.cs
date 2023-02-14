/*Написать программу, которая из имеющегося массива строк формируется массив из строк, длина 
которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать
на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", ""computer science] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/
Console.Clear();
int GetNumberOfLines(string message)
{
    ColorizeText(message, ConsoleColor.White);
    int variable = 0;
    if (int.TryParse(Console.ReadLine()!, out variable) && variable > 0)
        return variable;
    else
    {
        ColorizeText("Введено неверное значение", ConsoleColor.DarkRed);
        Console.WriteLine();
        return variable = GetNumberOfLines("Введите повторно количество строк (число д.б. " +
                                           "положительным и целочисленным) - ");
    }
}
string[] GetLinesFromUser(string message, int value)
{
    string[] array = new string[value];
    for (int i = 0; i < value; i++)
    {
        ColorizeText(message + $"{i + 1}: ", ConsoleColor.White);
        array[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
    return array;
}
void ColorizeText(string message, ConsoleColor myColor)
{
    Console.ForegroundColor = myColor;
    Console.Write(message);
    Console.ResetColor();
}
void DeletingLinesFromArray(string[] array, out string[] arrayNew, out int j)
{
    arrayNew = new string[array.Length];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
}
void PrintOfArray(string[] array, string message, int length, ConsoleColor myColor)
{
    ColorizeText(message + "[", myColor);
    for (int i = 0; i < length; i++)
    {
        if (i != length - 1)
            ColorizeText($"\"{array[i]}\", ", myColor);
        else
            ColorizeText($"\"{array[i]}\"", myColor);
    }
    ColorizeText("]", myColor);
    Console.WriteLine();
    Console.WriteLine();
}
int numberOfLines = GetNumberOfLines("Введите количество строк, которое хотите ввести в массив - ");
string[] linesUser = GetLinesFromUser("Введите строку № ", numberOfLines);
PrintOfArray(linesUser, "Строковый массив - ", linesUser.Length, ConsoleColor.DarkMagenta);
ColorizeText("Удаление из строкового массива строк с длиной более 3-х символов.", ConsoleColor.DarkRed);
Console.WriteLine();
Console.WriteLine();
DeletingLinesFromArray(linesUser, out string[] arrayLines, out int arrayLinesLength);
PrintOfArray(arrayLines, "Обновленный строковый массив - ", arrayLinesLength, ConsoleColor.DarkGreen);