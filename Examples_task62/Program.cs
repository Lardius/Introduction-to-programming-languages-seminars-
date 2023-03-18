using System;
using static System.Console;
Clear();

int n = int.Parse(Prompt("Введите размерность квадратного массива: "));

int[,] array = GetSpiralArray(n, true);
PrintArrayByElement(array);


string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,] GetSpiralArray(int n, bool direction = true)
{
    if (n < 0) { return new int[0, 0]; }
    int[,] a = new int[n, n];
    if (n > 1)
    {
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                int i = r + 1;
                int j = c + 1;
                int switcher = ((direction ? 1 : -1) * (c - r) + n) / n;
                int Ic = Math.Abs(i - n / 2 - 1) + (i - 1) / (n / 2) * ((n - 1) % 2);
                int Jc = Math.Abs(j - n / 2 - 1) + (j - 1) / (n / 2) * ((n - 1) % 2);
                int ring = n / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
                int Xs = i + j - 2 * ring - 1;
                int ringStartNum = 4 * ring * (n - ring);
                a[r, c] = switcher * Xs + Math.Abs(switcher - 1) * (4 * (n - 2 * ring) - 2 - Xs) + ringStartNum;
            }
        }
    }
    else if (n == 1)
    {
        a[0, 0] = 1;
    }
    return a;
}

void PrintArrayByElement(int[,] inArray)
{
    int i = 1;
    int n = inArray.GetLength(1);
    foreach (var item in inArray)
    {
        Write($"{item,3}" + ((i++ % n == 0) ? "\n" : ""));
    }
}