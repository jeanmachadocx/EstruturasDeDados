using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fila fila= new Fila(10);
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
                        Console.WriteLine(" Temos: " + fila.Contar() + " aguardando para decolagem ");
                        break;

                    case 2:
                        if (fila.Contar() == 0)
                        {
                            Console.WriteLine(" A fila está vazia");
                        }
                        else
                        {
                            fila.Remover();
                        }
                        break;

                    case 3:
                        Console.WriteLine(" Identificador do avião para inserir na fila");
                        int numeroAviao = int.Parse(Console.ReadLine());

                        fila.Inserir(numeroAviao);
                        break;

                    case 4:
                        if (fila.Contar() == 0)
                        {
                            Console.WriteLine(" A fila está vazia");
                        }
                        else
                        {
                            fila.Mostrar();
                        }
                        break;

                    case 5:
                        if (fila.Contar() == 0)
                        {
                            Console.WriteLine("Fila vazia");
                        }
                        else
                        {
                            Console.WriteLine(fila.ObterPrimeiro());
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
//4) CLASSE FILA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Fila
    {
        private int[] array;
        private int primeiro, ultimo, contador=0;

        public Fila(int tamanho)
        {
            array = new int[tamanho + 1];
            primeiro = ultimo = 0;
        }

        public void Inserir(int x)
        {
            if (((ultimo + 1) % array.Length) == primeiro)
            {
                throw new Exception("Erro!");
            }
            contador++;
            array[ultimo] = x;
            ultimo = (ultimo + 1) % array.Length;
        }

        public int Remover()
        {
            if (ultimo == primeiro)
            {
                throw new Exception("Erro! Fila vazia");
            }
            contador--;
            int resp = array[primeiro];
            primeiro = (primeiro + 1) % array.Length;
            return resp;
        }

        public void Mostrar()
        {
            int i = primeiro;
            while (i != ultimo)
            {
                Console.WriteLine(array[i] + " ");
                i = (i + 1) % array.Length;
            }
        }

        public int ObterPrimeiro()
        {
            if(ultimo == primeiro)
            {
                throw new Exception("Erro! Fila vazia");

            }
            return primeiro;
        }

        public int Contar()
        {
            return contador;
        }
    }
