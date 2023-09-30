using System;
namespace Exercicio4
{
public class Program
{
public static void Main(string[] args)
{
Console.WriteLine("Escreva dois número: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
Console.WriteLine(CalcularMDC(x,y));
Console.ReadKey();
}
public static int CalcularMDC(int x, int y)
{
int resto = 0;
if (y ==0 )
{
return x;
}
else
{
return CalcularMDC(y ,x % y);
}
}
}
}
