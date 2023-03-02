Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if(a > 99) {
    while (a > 99) {
        if(a < 1000) {
            System.Console.WriteLine("Вторая цифра " + a % 10);
        }
    a = a / 10;
}} else {
    System.Console.WriteLine("третьей цифры нет");
}