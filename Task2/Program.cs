// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int NumberInput(string text)
{
    System.Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void DigitsSum(int number)
{
    int result = 0;
    while (number >0)
    {
    result += number%10;
    number = number/10;
    }
    System.Console.WriteLine($"Сумма всех цифр {result}");
}


int input = NumberInput("Введите число: ");
DigitsSum(input);
