// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine()!);

int Ackerman(int M, int N)
    {
        if (M != 0)
            {
                if (N != 0) return Ackerman(M - 1, Ackerman(M, N - 1));
                return Ackerman(M - 1, 1);
            }

        return N + 1;
    }
Console.WriteLine($"результат вычесления функии Анкермана {Ackerman(M, N)}");