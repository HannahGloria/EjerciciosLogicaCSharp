using System;
public class Sumatoria
{
    public void Calcular()
    {
        int nSum = 5; // número hasta donde sumar
        int resultadoSum = 0;

        for (int i = 1; i <= nSum; i++)
        {
            resultadoSum += i; // resultadoSum = resultadoSum + i
        }

        Console.WriteLine("La sumatoria es: " + resultadoSum);
    }
}