using System;
using static System.Console;

Clear();
int m = int.Parse(Prompt("Введите количество строк массива: "));
int n = int.Parse(Prompt("Введите количество строк массива: "));

double[,] array = GetArray(m, n, 1, 100);
PrintArray(array);

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

double[,] GetArray(int m, int n, int minValue = 0, int maxValue = 0)
{
    double[,] result = new double[m, n];
    if (minValue != 0 && maxValue != 0)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / Convert.ToDouble(new Random().Next(minValue, maxValue + 1)),2);
            }
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}
