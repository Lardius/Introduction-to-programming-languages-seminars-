Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 2;
String p = "";
while (b < a) {
    if(p == "") {
        p = p + b;
    } else {
        p = p  + ", " + b;  
    }
    
    b = b + 2;
    
}
System.Console.WriteLine("Все чётные числа: " + p);