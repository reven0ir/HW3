/*
 
 Дано число. Визначити, чи є це число степенем двійки.

 */


Console.OutputEncoding = System.Text.Encoding.Default;

Console.WriteLine("Введіть число, яке треба визначити чи є це число степенем двійки: ");
int num = Convert.ToInt32(Console.ReadLine()); // вводимо число, яке перевіряємо

if ((num & (num - 1)) == 0)
{
    Console.WriteLine("Число є степенем двійки"); // якщо результат дорівнює 0, то число є степенем двійки
}
else
{
    Console.WriteLine("Число не є степенем двійки"); // якщо результат не дорівнює 0, то число не є степенем двійки
}