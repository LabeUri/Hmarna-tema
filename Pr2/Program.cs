using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int targetNumber = random.Next(0, 11); // Генеруємо випадкове число від 0 до 10
        int attempts = 0;
        bool guessed = false;

        Console.WriteLine("Вгадайте число від 0 до 10.");

        while (!guessed)
        {
            Console.Write("Введіть вашу догадку: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int guess))
            {
                if (guess < 0 || guess > 10)
                {
                    Console.WriteLine("Введене число повинно бути в межах від 0 до 10.");
                }
                else
                {
                    attempts++;

                    if (guess == targetNumber)
                    {
                        guessed = true;
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("Більше.");
                    }
                    else
                    {
                        Console.WriteLine("Менше.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Невірний формат вводу. Будь ласка, введіть ціле число від 0 до 10.");
            }
        }

        Console.WriteLine($"Ви вгадали число {targetNumber} за {attempts} спроб.");
        Console.WriteLine("Натисніть будь-яку клавішу, щоб завершити...");
        Console.ReadKey();

    }
}
