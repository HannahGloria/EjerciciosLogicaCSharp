using System;
public class Factorial
{
    public void Calcular()
    {
        int n = 10; // número hasta donde va a hacer el factorial
        int resultado = 1; //empieza en 1 porque vamos a multiplicar y no podemos multiplicar en 0 

        for (int i = 1; i <= n; i++)
        {
            resultado *= i; // resultado = resultado * i
        }

        Console.WriteLine("El factorial es: " + resultado);
    }
}