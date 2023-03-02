Console.WriteLine("Введите порядковый номер дня недели: ");
int a = int.Parse(Console.ReadLine());
bool b = true;

while(b) {
    if(a >= 1 && a <= 7) {
        if(a <= 5){
            b = false;
            System.Console.WriteLine("нет");
        } else {
            b = false;
            System.Console.WriteLine("да");
        }
    } else {
        System.Console.WriteLine("Необходимо ввести день недели (1-7)");
        Console.WriteLine("Введите порядковый номер дня недели: ");
        a = int.Parse(Console.ReadLine());
    }
}

