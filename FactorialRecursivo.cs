
using System;
public class FactorialRecursivo
{
    public static int CalcularFR(int n)
    {
        if (n <= 1)
            return 1;
        return n * CalcularFR(n - 1);
    }
}