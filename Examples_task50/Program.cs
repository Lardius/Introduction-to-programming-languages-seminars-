using System;
using static System.Console;
const int ROW = 0;     
const int COLUMN = 1;  

Clear();
int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество строк массива: "));
int[,] array = GetArray(m, n, 0, 9);
PrintArray(array, div: ", ");

int r = int.Parse(Prompt("Введите номер строки массива для поиска: "));
int c = int.Parse(Prompt("Введите номер колонки массива для поиска: "));

int? value = GetValueFromArray(r, c, array);
if (value != null)
{
    WriteLine($"Элемент на позиции [{r},{c}] = {GetValueFromArray(r, c, array)}");
}
else
{
    WriteLine($"Позиция [{r},{c}] отсутсвует. Индекс массива должен быть в пределах [0..{array.GetLength(ROW) - 1},0..{array.GetLength(COLUMN) - 1}]");
}

// Поиск нужного значения по элементам массива
int f = int.Parse(Prompt("Введите икомое число: "));
int[,] fArray = GetCoordinateOfValue(array, f);
if (fArray.Length == 0)
{
    WriteLine("Такого элемента нет.");
}
else
{
    PrintArray(fArray, "Найденные позиции элемента:\n", div: ", ");
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,] GetArray(int row, int column, int minValue = 0, int maxValue = 0)
{
    int[,] result = new int[row, column];
    if (!(minValue == 0 && maxValue == 0))
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray, string title = "", string div = "\t")
{
    if (title != "") { Write(title); }
    for (int r = 0; r < inArray.GetLength(ROW); r++)
    {
        Write("[");
        for (int c = 0; c < inArray.GetLength(COLUMN); c++)
        {
            Write($"{inArray[r, c]}{((c < inArray.GetLength(COLUMN) - 1) ? div : "")}");
        }
        WriteLine("]");
    }
}

int? GetValueFromArray(int row, int column, int[,] array)
{
    return ((column < array.GetLength(COLUMN) && column >= 0) && (row < array.GetLength(ROW) && row >= 0)) ? array[row, column] : null;
}

int[,] AddRowToArray(int[,] array, int newRow)
{
    int[,] result = new int[array.GetLength(ROW) + newRow, array.GetLength(COLUMN)];

    for (int r = 0; r < array.GetLength(ROW); r++)
    {
        for (int c = 0; c < array.GetLength(COLUMN); c++)
        {
            result[r, c] = array[r, c];
        }
    }
    return result;
}

int[,] GetCoordinateOfValue(int[,] array, int toFind)
{
    int[,] result = new int[0, 2];
    int count = 0;
    for (int r = 0; r < array.GetLength(ROW); r++)
    {
        for (int c = 0; c < array.GetLength(COLUMN); c++)
        {
            if (array[r, c] == toFind)
            {
                result = AddRowToArray(result, 1);
                result[count, 0] = r;
                result[count, 1] = c;
                count++;
            }
        }
    }
    return result;
}