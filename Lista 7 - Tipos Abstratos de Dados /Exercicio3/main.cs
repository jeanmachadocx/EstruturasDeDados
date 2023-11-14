using System;
using System.Security.Principal;

namespace Exercicio3
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            Fila fila = new Fila();
            int opcao = 0;
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine(" 1 = Inserir arquivo na fila de impressão ");
                Console.WriteLine(" 2 = Executar impressão");
                Console.WriteLine(" 3 = Exibir fila de impressão ");
                Console.WriteLine(" 4 Sair ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Infome o nome e o número de páginas ");
                        string nome = Console.ReadLine();
                        int numero = int.Parse(Console.ReadLine());
                        fila.Inserir(nome, numero);
                        break;

                    case 2:
                        Console.WriteLine("Arquivo enviado para impressão ");
                        fila.Remover();
                        break;

                    case 3:
                        Console.WriteLine("Fila de impressão: ");
                        fila.Mostrar();
                        break;

                    case 4:
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Opção inválida, infome um valor entre: 1 e 4");
                        break;

                }

            } while (opcao != 4);
        }
    }
}
