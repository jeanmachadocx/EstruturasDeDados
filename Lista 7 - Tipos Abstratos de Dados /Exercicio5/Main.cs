using System;


namespace Exercicio5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opcao = 0;
            Lista Lista = new Lista();
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine(" 1 - Inserir um tempo no início da lista ");
                Console.WriteLine(" 2 - Inserir um tempo no final da lista ");
                Console.WriteLine(" 3 - Inserir um tempo numa posição específica da lista ");
                Console.WriteLine(" 4 - Remover o primeiro tempo da lista ");
                Console.WriteLine(" 5 - Remover o último tempo da lista ");
                Console.WriteLine(" 6 - Remover um tempo de uma posição específica na lista ");
                Console.WriteLine(" 7 - Remover um tempo específico da lista ");
                Console.WriteLine(" 8 - Pesquisar quantas vezes um determinado tempo consta na lista ");
                Console.WriteLine(" 9 - Mostrar todos os tempos da lista");
                Console.WriteLine(" 10 - Sair ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Infome o tempo para inserir no início ");
                        int numero = int.Parse(Console.ReadLine());
                        Lista.InserirInicio(numero);
                        break;

                    case 2:
                        Console.WriteLine("Infome o tempo para inserir no fim ");
                        int numero1 = int.Parse(Console.ReadLine());
                        Lista.InserirFim(numero1);
                        break;

                    case 3:
                        Console.WriteLine("Infome o tempo para e a posição ");
                        int numero3 = int.Parse(Console.ReadLine());
                        int pos = int.Parse(Console.ReadLine());
                        Lista.Inserir(numero3, pos);
                        break;

                    case 4:
                        Console.WriteLine("Removendo o primeiro tempo");
                        Lista.RemoverInicio();
                        break;

                    case 5:
                        Console.WriteLine("Removendo o último tempo");
                        Lista.RemoverFim();
                        break;

                    case 6:
                        Console.WriteLine("Infome a posição ");
                        int pos1 = int.Parse(Console.ReadLine());
                        Lista.Remover(pos1);
                        break;

                    case 7:
                        Console.WriteLine("Informe o tempo");
                        int tempo = int.Parse(Console.ReadLine());
                        Lista.Remover(tempo);

                        break;

                    case 8:
                        Console.WriteLine("Qual o tempo deseja contar as aparições");
                        int buscar = int.Parse(Console.ReadLine());
                        Lista.Contar(buscar);

                        break;

                    case 9:
                        Lista.Mostrar();
                        break;

                    default:
                        Console.WriteLine("Opção inválida, infome um valor entre: 1 e 9 ou 10 para SAIR");
                        break;

                }

            } while (opcao != 10);

        }
    }
}
