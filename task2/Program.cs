Console.Clear();
Console.WriteLine("Введите число m: ");

int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");

int n = Convert.ToInt32(Console.ReadLine());


int FindSumOfNatural(int m, int n)
{
    int sum = 0;
    if (m<n && m > 0 && n > 0)
    {
        sum = m + FindSumOfNatural(m+1, n);
        return sum;
    }
    else 
    {
        sum = sum + n;
        return sum;
    }
}

Console.WriteLine($"Сумма: {FindSumOfNatural(m, n)}");