using System;

Console.OutputEncoding = System.Text.Encoding.Default;

Console.WriteLine("Гра 'Більше-менше'");

Random rand = new Random();
int secretNumber = rand.Next(1, 11);

Console.Write("Введіть максимальну кількість спроб: ");
int maxAttempts = int.Parse(Console.ReadLine());

int attempt = 0;

while (attempt < maxAttempts)
{
    Console.Write("Введіть число від 1 до 10: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("Ви вгадали!");
        return;
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Загадане число більше.");
    }
    else
    {
        Console.WriteLine("Загадане число менше.");
    }

    attempt++;
}
        Console.WriteLine("Ви не вгадали за {0} спроб.", maxAttempts);