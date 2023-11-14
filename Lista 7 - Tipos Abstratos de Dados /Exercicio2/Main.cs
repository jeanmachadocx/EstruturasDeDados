
using System;

namespace Exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pilha pilha = new Pilha();
            Console.WriteLine("Informe um valor: ");
            int num = int.Parse(Console.ReadLine());  

            const int basee = 8;
            int resultado;

            int resto;
            do
            {
                resto = num % basee;
                resultado = num / basee;
                pilha.Inserir(resto);
                num = resultado;
            } while (num > 0);


            pilha.Mostrar();

            Console.ReadKey();
        }
    }
}

