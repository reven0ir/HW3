Console.OutputEncoding = System.Text.Encoding.Default;

double a = 0.0;  // початок відрізку
double b;

Console.WriteLine("За замовчуванням початок відрізку = 0.0\n");

Console.WriteLine("Введіть кількість відрізків: ");
int c = Convert.ToInt32(Console.ReadLine()); // кількість відрізків

Console.WriteLine("Введіть кінець відрізку: ");
b = Convert.ToDouble(Console.ReadLine()); // кінець відрізку

double h = (b - a) / c;  // довжина кожного відрізку

Console.WriteLine($"Довжина кожного відрізку: {h}");
Console.Write($"Точки розбиття відрізку [{a}, {b}]: ");

for (int i = 0; i <= c; i++)
{
    double x = a + i * h;
    Console.Write($"\n{x}; ");
}
Console.WriteLine();