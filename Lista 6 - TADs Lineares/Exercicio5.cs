using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Fila fila = new Fila(10);
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção: \n ");
                Console.WriteLine(" 1) Inserir arquivo na fila de impressão ");
                Console.WriteLine(" 2) Executar impressão");
                Console.WriteLine(" 3) Exibir fila de impressão ");
                Console.WriteLine(" 4) Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Número de páginas: ");
                        int numeroPaginas = int.Parse(Console.ReadLine());
                        fila.Inserir(numeroPaginas);
                        break;

                    case 2:
                        if (fila.Contar() == 0)
                        {
                            Console.WriteLine(" A fila está vazia");
                        }
                        else
                        {
                            fila.ObterPrimeiro();
                        }
                        break;

                    case 3:
                        if (fila.Contar() == 0)
                        {
                            Console.WriteLine(" A fila está vazia");
                        }
                        else
                        {
                            fila.Mostrar();
                        }
                        break;

                    case 4:
                        Console.WriteLine(" Encerrando o programa");
                        break;

                    default:
                        Console.WriteLine(" Opção inválida");
                        break;
                }

            } while (opcao != 4);

            Console.ReadKey();
        }
    }
}


//5 CLASSE FILA
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
            int resp = primeiro;
            primeiro = (primeiro + 1)% array.Length;
            return resp;
        }

        public int Contar()
        {
            return contador;
        }
    }
