Console.WriteLine("Введите трехзначное число");
int a =int.Parse(Console.ReadLine());

if(a >= 100 && a < 1000) {
    System.Console.WriteLine("Вторая цифра " + a /10 % 10);
} else {
    System.Console.WriteLine("Число не трехзначное");
}
