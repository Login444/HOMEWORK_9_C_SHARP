// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();
Console.WriteLine("Введите число m: ");

int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");

int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return AkkermanFunc(m - 1, 1);
        }
        else
        {
            return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
        }
    }

}

Console.WriteLine($"Результат выполнения функции Аккермана: {AkkermanFunc(m,n)}");