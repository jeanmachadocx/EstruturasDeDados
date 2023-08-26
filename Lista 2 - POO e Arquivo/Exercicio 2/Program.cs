using System;


namespace Exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(01, "Jean");
            Cliente cliente2 = new Cliente(02, "Maria");
            Cliente cliente3 = new Cliente(03, "Fulano");

            Console.WriteLine("Cliente 1 - Nome: " + cliente1.GetNome() + " Código: " + cliente1.GetCodigo());
            Console.WriteLine("Cliente 2 - Nome: " + cliente2.GetNome() + " Código: " + cliente2.GetCodigo());
            Console.WriteLine("Cliente 3 - Nome: " + cliente3.GetNome() + " Código: " + cliente3.GetCodigo());

            cliente1.AtualizarCategoria(true);
            cliente2.AtualizarCategoria(false);
            cliente3.AtualizarCategoria(true);

            Console.WriteLine();
            Console.WriteLine("Cliente 1 é Cliente Especial? " + cliente1.AtualizarLimite(50000));
            Console.WriteLine("Cliente 2 é Cliente Especial? " + cliente2.AtualizarLimite(50000));
            Console.WriteLine("Cliente 3 é Cliente Especial? " + cliente3.AtualizarLimite(50000));



            Console.ReadKey();
        }
    }
}
