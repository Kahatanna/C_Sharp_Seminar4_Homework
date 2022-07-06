/*

Задача 25: Напишите //цикл
программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

// Метод возвращает число из консоли
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while(true)
    {
        
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result))
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


int number = GetNumber("Введите число для возведения в степень: ");
int degree = GetNumber("Введите степень: ");

Console.WriteLine($"Число {number} в степени {degree} = {Math.Pow(number,degree)}"); 