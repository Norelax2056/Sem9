//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine()!);

void Numbers(int n)
{
if (n > 1)
{
	Console.Write($"{n}, ");
	Numbers(n-1);
}
else Console.Write($"{n}\"");
return;
}
Console.Write($"N = {num} -> \"");
Numbers(num);