System.Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Точки А: x = ");
int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Точки А: y = ");
int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Точки А: z = ");
int Az = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Точки B: x = ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Точки B: y = ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine("Точки B: z = ");
int Bz = int.Parse(Console.ReadLine());
System.Console.WriteLine("Координаты точки А: (" + Ax + "; " + Ay + "; " + Az + ")");
System.Console.WriteLine("Координаты точки B: (" + Bx + "; " + By + "; " + Bz + ")");


System.Console.WriteLine(Math.Pow((Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2) + Math.Pow((Bz - Az), 2)), 0.5));