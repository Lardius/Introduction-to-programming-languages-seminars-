using System;
using static System.Console;
int ROW = 0;
int COLUMN = 1;
Clear();

int row = int.Parse(Prompt("Введите количество строк: "));
int column = int.Parse(Prompt("Введите количество столбцов: "));
int k = int.Parse(Prompt("Введите поколение: "));
int[,] firstGeneration = GetArray(row, column);

int[,] kGeneration = GetKGenerationOfLife(firstGeneration, k);

WriteLine("Исходное поколение:");
PrintTwoDemensionsArrayChar(ChangeIntToChar(firstGeneration));
WriteLine();

WriteLine($"{k} поколение:");
PrintTwoDemensionsArrayChar(ChangeIntToChar(kGeneration));
WriteLine();

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

int[,] GetArray(int row, int column, int minValue = 0, int maxValue = 0)
{
    int[,] result = new int[row, column];
    for (int r = 0; r < row; r++)
    {
        for (int c = 0; c < column; c++)
        {
            result[r, c] = new Random().Next(2);
        }
    }
    return result;
}

void PrintTwoDemensionsArrayChar(char[,] inArray)
{
    for (int r = 0; r < inArray.GetLength(ROW); r++)
    {
        for (int c = 0; c < inArray.GetLength(COLUMN); c++)
        {
            Write($"{inArray[r, c]} ");
        }
        WriteLine();
    }
}

void PrintTwoDemensionsArray(int[,] inArray)
{
    for (int r = 0; r < inArray.GetLength(ROW); r++)
    {
        for (int c = 0; c < inArray.GetLength(COLUMN); c++)
        {
            Write($"{inArray[r, c]} ");
        }
        WriteLine();
    }
}

int[,] ResizeMassive(int[,] array)
{
    int countCol = array.GetLength(COLUMN) + 2;
    int countRow = array.GetLength(ROW) + 2;
    int[,] result = new int[countRow, countCol];
    for (int r = 1; r < countRow - 1; r++)
    {
        for (int c = 1; c < countCol - 1; c++)
        {
            result[r, c] = array[r - 1, c - 1];
            if (r == 1) result[r - 1, c] = array[countRow - 3, c - 1];
            if (r == countRow - 2) result[r + 1, c] = array[0, c - 1];
        }
        result[r, 0] = array[r - 1, countCol - 3];
        result[r, countCol - 1] = array[r - 1, 0];
    }
    result[0, 0] = array[countRow - 3, countCol - 3];
    result[countRow - 1, countCol - 1] = array[0, 0];
    result[0, countCol - 1] = array[countRow - 3, 0];
    result[countRow - 1, 0] = array[0, countCol - 3];

    return result;
}

char[,] ChangeIntToChar(int[,] array)
{
    char[,] result = new char[array.GetLength(ROW), array.GetLength(COLUMN)];
    for (int r = 0; r < array.GetLength(ROW); r++)
    {
        for (int c = 0; c < array.GetLength(COLUMN); c++)
        {
            result[r, c] = (array[r, c] == 1 ? '*' : '.');
        }
    }
    return result;
}

int[,] NextGeneration(int[,] array)
{
    int[,] result = new int[array.GetLength(ROW), array.GetLength(COLUMN)];
    int[,] arrayWorld = ResizeMassive(array);
    int count = 0;
    for (int r = 1; r < arrayWorld.GetLength(ROW) - 1; r++)
    {
        for (int c = 1; c < arrayWorld.GetLength(COLUMN) - 1; c++)
        {
            result[r - 1, c - 1] = arrayWorld[r, c];

            count = (arrayWorld[r, c] == 1) ? -1 : 0;
            for (int rw = r - 1; rw < r + 2; rw++)
            {
                for (int cw = c - 1; cw < c + 2; cw++)
                {
                    count += arrayWorld[rw, cw];
                }
            }

            if ((arrayWorld[r, c] == 0) && (count == 3))
            {
                result[r - 1, c - 1] = 1;
            }
            if ((arrayWorld[r, c] == 1) && (count < 2 || count > 3))
            {
                result[r - 1, c - 1] = 0;
            }
        }
    }
    return result;
}

int[,] GetKGenerationOfLife(int[,] array, int gen)
{
    int[,] result = array;
    for (int n = 0; n < gen; n++)
    {
        result = NextGeneration(result);
    }
    return result;
}