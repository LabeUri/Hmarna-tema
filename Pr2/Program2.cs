using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3];

        // Зчитуємо значення елементів матриці від користувача
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Введіть елемент [{i + 1},{j + 1}]: ");
                if (int.TryParse(Console.ReadLine(), out int element))
                {
                    matrix[i, j] = element;
                }
                else
                {
                    Console.WriteLine("Невірний формат числа. Будь ласка, введіть ціле число.");
                    j--; // Повторити введення для поточного елемента
                }
            }
        }

        int sum = CalculateDiagonalSum(matrix);

        Console.WriteLine($"Сума елементів головної діагоналі матриці: {sum}");
        Console.WriteLine("Натисніть будь-яку клавішу, щоб завершити...");
        Console.ReadKey();

    }

    static int CalculateDiagonalSum(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
}
