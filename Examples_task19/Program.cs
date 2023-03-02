Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());

if(a % 10 == a / 10000 && a / 10 % 10 == a / 1000 % 10) {
    System.Console.WriteLine("да");
} else {
    System.Console.WriteLine("нет");
}


