using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fila filaMestrado = new Fila();
            Fila filaIniciacaoCientifica = new Fila();

            int opcao = 0; ;
            do
            {

                Console.WriteLine(" Escolha uma opção: ");
                Console.WriteLine(" 1) Inserir um aluno na fila de espera de bolsas de Iniciação Científica ");
                Console.WriteLine(" 2) Inserir um aluno na fila de espera de bolsas de Mestrado ");
                Console.WriteLine(" 3) Remover um aluno da fila de bolsas de Iniciação Científica ");
                Console.WriteLine(" 4) Remover um aluno da fila de bolsas de Mestrado ");
                Console.WriteLine(" 5) Mostrar fila de espera de bolsas de Iniciação Científica ");
                Console.WriteLine(" 6) Mostrar fila de espera de bolsas de Mestrado");
                Console.WriteLine(" 7) Pesquisar aluno na fila de espera de bolsas de Iniciação Científica ");
                Console.WriteLine(" 8) Pesquisar aluno na fila de espera de bolsas de Mestrado ");
                Console.WriteLine(" 9) Encerrar o programa ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o ID para adicionar na fila de espera de bolsas de Iniciação Científica");
                        int matricula1 = int.Parse(Console.ReadLine());
                        filaIniciacaoCientifica.Inserir(matricula1);

                        break;

                    case 2:
                        Console.WriteLine("Informe o ID para adicionar na fila de espera de bolsas de Mestrado ");
                        int matricula2 = int.Parse(Console.ReadLine());
                        filaMestrado.Inserir(matricula2);
                        break;

                    case 3:
                        Console.WriteLine("Removendo da fila de bolsas de Iniciação Científica");
                        filaIniciacaoCientifica.Remover();
                        break;

                    case 4:
                        Console.WriteLine("Removendo da fila de bolsas de Mestrado");
                        filaMestrado.Remover();
                        break;

                    case 5:
                        Console.WriteLine("Fila de Iniciação Científica: ");
                        filaIniciacaoCientifica.Mostrar();
                        break;

                    case 6:
                        Console.WriteLine("Fila de Mestrado : ");
                        filaMestrado.Mostrar();
                        break;

                    case 7:
                        Console.WriteLine("Informe a matrícula do aluno de Iniciação Científica que deseja buscar: ");
                        int buscar1 = int.Parse(Console.ReadLine());
                        if (filaIniciacaoCientifica.Pesquisar(buscar1))
                            Console.WriteLine($"Aluno com matrícula {buscar1} está na fila de Iniciação Científica.");
                        else
                            Console.WriteLine($"Aluno com matrícula {buscar1} NÃO está na fila de Iniciação Científica.");
                        break;

                    case 8:
                        Console.WriteLine("Informe a matrícula do aluno de Mestrado que deseja buscar: ");
                        int buscar2 = int.Parse(Console.ReadLine());
                        if (filaMestrado.Pesquisar(buscar2))
                            Console.WriteLine($"Aluno com matrícula {buscar2} está na fila de Iniciação Científica.");
                        else
                            Console.WriteLine($"Aluno com matrícula {buscar2} NÃO está na fila de Iniciação Científica.");
                        break; 

                    case 9:
                        Console.WriteLine("Encerrando o programa ");
                        break;

                    default:
                        Console.WriteLine(" Escolha uma opção válida ");
                        break;

                }
            } while (opcao != 9);
        }
    }
}
