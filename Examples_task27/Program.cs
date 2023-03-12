int Prompt (string message) {
    System.Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
} 



int TheSumOfAllTheNumbers (int num) {
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int num = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {num} = {TheSumOfAllTheNumbers(num)}");