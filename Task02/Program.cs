/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/


// Метод возвращает число из консоли
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

// Метод ищет суммц цифр числа
int SumDigit(int num)
{
    int result = 0;
    int remainder = num;

    while (remainder > 1)
    {
        result += remainder % 10;
        remainder = remainder / 10;       
    }

    return result;
}

int number = GetNumber("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number} = {SumDigit(number)}");