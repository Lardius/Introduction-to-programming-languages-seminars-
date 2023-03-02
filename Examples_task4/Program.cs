Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;

System.Console.WriteLine("Максимальное из этих чисел = " + max);

