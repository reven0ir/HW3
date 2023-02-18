/*
 
 Дано целое число N (> 1) и две вещественные точки на числовой оси:
A, B (A < B). Отрезок [A, B] разбит на N равных отрезков. Вывести H —
длину каждого отрезка, а также набор точек
A, A + H, A + 2·H, A + 3·H, . . . , B

 */

Console.OutputEncoding = System.Text.Encoding.Default;

double a = 0.0;  // початок відрізку
double b;

Console.WriteLine("За замовчуванням початок відрізку = 0.0\n");

Console.WriteLine("Введіть кількість відрізків: ");
int c = Convert.ToInt32(Console.ReadLine()); // кількість відрізків

Console.WriteLine("Введіть кінець відрізку: ");
b = Convert.ToDouble(Console.ReadLine()); // кінець відрізку

double h = (b - a) / c; // довжина кожного відрізку

Console.WriteLine($"Довжина кожного відрізку: {h}");
Console.Write($"Точки розбиття відрізку [{a}, {b}]: ");

Console.ForegroundColor = ConsoleColor.Green;

for (int i = 0; i <= c; i++)
{
    double x = a + i * h;
    Console.Write($"\n{x} ");
}

Console.ResetColor();
Console.WriteLine();