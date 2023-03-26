//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите натуральное число (элемент M): ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Введите натуральное число (элемент N): ");
int numberN = int.Parse(Console.ReadLine()!);


int Numbers(int numberM, int numberN)
{
 
    if (numberM <= numberN) return numberM  += Numbers(numberM + 1, numberN);
    else return 0;
}

Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна {Numbers(numberM, numberN)}");