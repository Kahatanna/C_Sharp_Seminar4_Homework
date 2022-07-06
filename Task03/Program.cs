/*

Задача 29: Напишите программу, которая задаёт массив из // 8 
N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

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

// Метод заполняет и распечатывает массив с числами от 1 до 99
void FillAndPrintArray(int count)
{
    int[] array = new int[count];
    Random rnd = new Random();

    Console.Write("[");
    int i = 0;

    // while чтобы формат вывода соблюсти 
    while (i < array.Length)
    {
        array[i] = rnd.Next(1, 100);
        Console.Write($"{array[i]}");
        i++;
        if (i < array.Length) Console.Write(", ");
    }
    Console.Write("]");
}


int number = GetNumber("Введите количество элементов массива: ");
FillAndPrintArray(number);