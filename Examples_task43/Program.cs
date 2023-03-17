int X = 0; 
int Y = 1; 
int K = 0; 
int B = 1; 

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}

double?[] GetCrossCoordinate(double[] first, double[] second)
{
    double?[] res = new double?[2];
    if (first[K] == second[K])
    {
        res[X] = null;
        res[Y] = (first[B] == second[B]) ? null : 0;  
    }
    else
    {
        res[X] = (first[B] - second[B]) / (second[K] - first[K]);
        res[Y] = first[K] * res[X] + first[B];
    }
    return res;
}

double[] firstLine = Prompt("Введите первое линейное уравнение вида y=kx+b -> у=")
                    .ToLower()                          
                    .Replace("х", "x")                  
                    .Split("x")                         
                    .Select(item => double.Parse(item)) 
                    .ToArray();                         
double[] secondLine = Prompt("Введите второе линейное уравнение вида y=kx+b -> у=")
                    .ToLower()
                    .Replace("х", "x")
                    .Split("x")
                    .Select(item => double.Parse(item))
                    .ToArray();
double?[] crossCoordinate = GetCrossCoordinate(firstLine, secondLine);

if (crossCoordinate[X] != null)
{
    Console.WriteLine($"({crossCoordinate[X]}; {crossCoordinate[Y]})");
}
else
{
    if (crossCoordinate[Y] == null)
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else
    {
        Console.WriteLine("Прямые паралельны.");
    }
}