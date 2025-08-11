
using System;

class Program
{
    static void Main()
    {
        Factorial factorial = new Factorial();
        factorial.Calcular();

        Sumatoria sumatoria = new Sumatoria();
        sumatoria.Calcular();

        //Factorial recursivo pidiendo al usuario que ingrese el numero
        Console.Write("Ingrese un número para calcular su factorial (recursivo): ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int n))
        {
            int resultado = FactorialRecursivo.CalcularFR(n);
            Console.WriteLine($"El factorial de {n} es {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
        }
    }
}
