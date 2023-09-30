using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
 /*) Escreva um programa que simule o controle de uma pista de decolagem de aviões em um aeroporto. Neste programa,
    o usuário deve ser capaz de realizar as seguintes tarefas:
    1. Listar a quantidade de aviões que estão aguardando na fila de decolagem
    2. Autorizar a decolagem do primeiro avião da fila de decolagem (isto é, retirar da fila de colagem)
    3. Adicionar um avião na fila de colagem
    4. Listar todos os aviões que estão na fila de colagem
    5. Exibir o primeiro avião da fila de colagem
    6. Sair
    Obs: A fila deve armazenar o identificador de cada avião (string).
    Dicionário
*/

            Queue<string> fila = new Queue<string>();
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção: \n ");
                Console.WriteLine(" 1) Listar a quantidade de aviões que estão aguardando na fila de decolagem");
                Console.WriteLine(" 2) Autorizar a decolagem do primeiro avião da fila de decolagem  ");
                Console.WriteLine(" 3)  Adicionar um avião na fila de colagem");
                Console.WriteLine(" 4) Listar todos os aviões que estão na fila de colagem");
                Console.WriteLine(" 5) Exibir o primeiro avião da fila de colagem");
                Console.WriteLine(" 6) Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(" Temos: " + fila.Count + " aguardando para decolagem ");
                        break;

                    case 2:
                        if (fila.Count == 0)
                        {
                            Console.WriteLine(" A fila está vazia");
                        }
                        else
                        {
                            fila.Dequeue();
                        }
                        break;

                    case 3:
                        Console.WriteLine(" Identificador do avião para inserir na fila");
                        string numeroAviao = Console.ReadLine();

                        fila.Enqueue(numeroAviao);
                        break;

                    case 4:
                        if (fila.Count == 0)
                        {
                            Console.WriteLine(" A fila está vazia");
                        }
                        else
                        {
                            foreach (string percorrerFila in fila)
                            {
                                Console.Write(percorrerFila + " ");
                            }
                        }
                        break;

                    case 5:
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("Fila vazia");
                        }
                        else
                        {
                            Console.WriteLine(fila.Peek());
                        }
                        break;

                    case 6:
                        Console.WriteLine(" Encerrando o programa");
                        break;

                    default:
                        Console.WriteLine(" Opção inválida");
                        break;
                }

            } while (opcao != 6);
            
            Console.ReadKey();
        }
    }
}
