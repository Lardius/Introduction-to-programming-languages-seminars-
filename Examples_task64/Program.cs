using static System.Console;
Clear();

int n = int.Parse(Prompt("Введите значение N: "));
WriteLine($"N = {n} -> {GetNatural(n)}");

/* Методы */
string GetNatural(int n)
{
    return (n == 1) ? Convert.ToString(n) : Convert.ToString(n) + ", " + GetNatural(n - 1);
}

string Prompt(string intro, bool oneline = true)
{
    Console.Write($"{intro}" + ((oneline) ? "" : "\n").ToString());
    string res = Console.ReadLine() ?? "";
    return res;
}