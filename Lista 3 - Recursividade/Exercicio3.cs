using System;
namespace Exercicio3
{
public class Program
{
public static void Main(string[] args)
{
Console.WriteLine("Escreva um número: ");
int numero = int.Parse(Console.ReadLine());
Console.WriteLine(ConverterBinario(numero));
Console.ReadKey();
}
public static int ConverterBinario(int dividendo)
{
int resto = 0;
if (dividendo < 2)
{
return 1;
}
else
{
resto = dividendo % 2;
Console.Write(resto);
return ConverterBinario(dividendo / 2);
}
}
}
}
