// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// * при N < 0, нужно вывести от N до -1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());
String p = "";
int b = 0;

if(a > 0) {
    while(a > b) {
        b++;
        
        if(p == "") {
        p = p + Math.Pow(b, 3);
    } else {
        p = p  + ", " + Math.Pow(b, 3);  
    }
    
}} else {
        while(a < b) {
               
        
        if(p == "") {
        p = p + Math.Pow(a, 3);
    } else {
        p = p  + ", " + Math.Pow(a, 3);  
    }
    a++; 
    
}
}

System.Console.WriteLine(p);
