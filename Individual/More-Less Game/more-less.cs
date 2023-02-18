/*
 
Скласти програму-гру «Більше-Менше». Комп’ютер генерує випадкове ціле число, а користувач намагається вгадати згенероване число. 
Комп’ютер надає користувачу підказку, чи є введене число більшим або меншим від загаданого. 
Також з клавіатури вводиться максимальна кількість спроб.

 */



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
    Console.Write("\nВведіть число від 1 до 10: ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\nВи вгадали!");
        Console.ResetColor();
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
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n\nВи не вгадали за {0} спроб.", maxAttempts);
Console.ResetColor();