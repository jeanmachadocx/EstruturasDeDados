using System;
namespace Exercicio1
{
public class Program
{
public static void Main(string[] args)
{
Console.WriteLine("Informe a base e o expoente:");
int numero = int.Parse(Console.ReadLine());
int vezes = int.Parse(Console.ReadLine());
Console.WriteLine(Calcular(numero, vezes));
Console.ReadKey();
}
public static int Calcular(int numero, int vezes)
{
if (vezes == 1) return numero;
else
{
return Calcular(numero + numero, vezes - 1);
}
}
}
}
