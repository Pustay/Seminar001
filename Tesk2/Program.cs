// Напишите программу, которая на вход принимает два
// числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число 1, ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2, ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"{a} больше {b}");
}
else if (a < b)
{
    Console.WriteLine($"{a} меньше {b}");
}
else
{
    Console.WriteLine("Оба числа равны");
}
Console.ReadKey();