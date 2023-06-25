// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double NumberInput(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void RaiseDegree(double number, double dergee)
{
    double result = Math.Pow(number, dergee);
    System.Console.WriteLine(result);
}

double numberA = NumberInput("Введите число: ");
double numberB = NumberInput("Введите степень: ");
RaiseDegree(numberA, numberB);

