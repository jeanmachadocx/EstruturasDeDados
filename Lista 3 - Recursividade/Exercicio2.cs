using System;
namespace Exercicio2
{
public class Program
{
public static void Main(string[] args)
{
Console.WriteLine("Escreva dois números, um para o começo e outro para o fim");
int comeco = int.Parse(Console.ReadLine());
int fim = int.Parse(Console.ReadLine());
Console.WriteLine(Calcular(comeco, fim));
Console.ReadKey();
}
public static int Calcular(int comeco, int fim)
{
if(fim == comeco) return comeco;
else
{
return comeco + Calcular(comeco +1, fim);
}
}
}
}
