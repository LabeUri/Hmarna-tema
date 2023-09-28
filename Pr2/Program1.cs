using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        // Зчитуємо числа від користувача та зберігаємо їх у масив
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Введіть число {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine("Невірний формат числа. Будь ласка, введіть ціле число.");
                i--; // Повторити введення для поточного числа
            }
        }

        int minPositive = FindMinPositive(numbers);

        if (minPositive != int.MaxValue)
        {
            Console.WriteLine($"Найменше додатнє число в списку: {minPositive}");
        }
        else
        {
            Console.WriteLine("У списку немає додатніх чисел.");
        }
        Console.WriteLine("Натисніть будь-яку клавішу, щоб завершити...");
        Console.ReadKey();

    }

    static int FindMinPositive(int[] numbers)
    {
        int minPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }

        return minPositive;
    }
}
