using Exercicio1;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o tamanho da lista: ");
        int tamanho = int.Parse(Console.ReadLine());
        Lista lista = new Lista(tamanho);
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção: \n ");
            Console.WriteLine(" 1) Inserir um tempo no início da lista");
            Console.WriteLine(" 2) Inserir um tempo no final da lista");
            Console.WriteLine(" 3) Inserir um tempo numa posição específica da lista");
            Console.WriteLine(" 4) Remover o primeiro tempo da lista (Imprimir o tempo removido)");
            Console.WriteLine(" 5) Remover o último tempo da lista (Imprimir o tempo removido)");
            Console.WriteLine(" 6) Remover um tempo de uma posição específica na lista (usuário deve informar a posição do tempo a ser");
            Console.WriteLine(" 7) Remover um tempo específico da lista (O usuário deve informar o tempo a ser removido)");
            Console.WriteLine(" 8) Pesquisar quantas vezes um determinado tempo consta na lista(O usuário deve informar o tempo a ser pesquisado)");
            Console.WriteLine(" 9) Mostrar todos os tempos da lista");
            Console.WriteLine(" 10) Encerrar o programa!");

            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe um tempo que deseja registrar: ");
                    int tempo = int.Parse(Console.ReadLine());
                    lista.InserirInicio(tempo);
                    break;
                case 2:
                    Console.WriteLine("Informe um tempo que deseja registrar: ");
                    int tempoFinal = int.Parse(Console.ReadLine());
                    lista.Inserir(tempoFinal);
                    break;
                case 3:
                    Console.WriteLine("Informe a posição: ");
                    int posicao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe um tempo que deseja registrar: ");
                    int tempoNovo = int.Parse(Console.ReadLine());
                    lista.InserirEm(tempoNovo, posicao);
                    break;
                case 4:
                    lista.RemoverInicio();
                    lista.Mostrar();
                    break;

                case 5:
                    lista.RemoverFim();
                    lista.Mostrar();
                    break;

                case 6:
                    Console.WriteLine("Escolha uma posição para exlcuir: ");
                    int posicaoRemover = int.Parse(Console.ReadLine());
                    lista.Remover(posicaoRemover);

                    break;

                case 7:
                    Console.WriteLine("Informe o tempo a ser removido: ");
                    int tempoRemover = int.Parse(Console.ReadLine());
                    lista.RemoverItem(tempoRemover);

                    break;

                case 8:
                    Console.WriteLine("Informe o tempo que deseja verificar");
                    int buscarTempo = int.Parse(Console.ReadLine());
                    lista.Contar(buscarTempo);
                    break;
                case 9:
                    lista.Mostrar();
                    break;
                case 10:
                    Console.WriteLine("Encerrando o programa");
                    break;

                default: Console.WriteLine("Opção inválida"); break;
            }
        } while (opcao != 10);
    }
}

//CLASSE LISTA 
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Exercicio1
{

    public class Lista
    {
        private int[] array;
        private int n;
        /**
        * Construtor da classe.
*/
        public Lista(int tamanho)
        {
            array = new int[tamanho];
            n = 0;
        }
        /**
        * Insere um elemento na primeira posicao da lista e move os demais
        * elementos para o fim da lista.
*/
        public void InserirInicio(int x)
        {
            if (n >= array.Length)
            {
                throw new Exception("Erro ao inserir!");
            }
            for (int i = n; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = x;
            n++;
        }
        /**
        * Insere um elemento na ultima posicao da lista.
*/
        public void Inserir(int x)
        {
            if (n >= array.Length)
            {
                throw new Exception("Erro ao inserir!");
            }
            array[n] = x;
            n++;
        }
        /**
        * Insere um elemento em uma posicao especifica e move os demais
        * elementos para o fim da lista.
*/
        public void InserirEm(int x, int pos)
        {
            if (n >= array.Length || pos < 0 || pos > n)
            {
                throw new Exception("Erro ao inserir!");
            }
            for (int i = n; i > pos; i--)
            {
                array[i] = array[i - 1];
            }
            array[pos] = x;
            n++;
        }
        /**
        * Remove um elemento da primeira posicao da lista e movimenta
        * os demais elementos para o inicio da mesma.
*/
        public int RemoverInicio()
        {
            if (n == 0)
            {
                throw new Exception("Erro ao remover!");
            }
            int resp = array[0];
            n--;
            for (int i = 0; i < n; i++)
            {
                array[i] = array[i + 1];
            }
            return resp;
        }
        /**
        * Remove um elemento da ultima posicao da lista.
*/
        public int RemoverFim()
        {
            if (n == 0)
            {
                throw new Exception("Erro ao remover!");
            }
            n--;
            return array[n];
        }
        /**
        * Remove um elemento de uma posicao especifica da lista e
        * movimenta os demais elementos para o inicio da mesma.
*/
        public int Remover(int pos)
        {
            if (n == 0 || pos < 0 || pos >= n)
            {
                throw new Exception("Erro ao remover!");
            }
            int resp = array[pos];
            n--;
            for (int i = pos; i < n; i++)
            {
                array[i] = array[i + 1];
            }
            return resp;
        }
        /**
        * Mostra os elementos da lista separados por espacos.
*/
        public void Mostrar()
        {
            Console.Write("[ ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("]");
        }

        public int RemoverItem(int x)
        {
            if (n == 0 || x < 0 || x >= n)
            {
                throw new Exception("Erro ao remover!");
            }
            int resp = array[x];
            
            for (int i = x; i < n ; i++)
            {
                array[i] = array[i + 1];
            }
            n--;
            return resp;
        }

        public void Contar(int x)
        {
            int contador = 0;
            if (n == 0 )
            {
                throw new Exception("Erro: Lista vazia");
            }

            for (int  i = 0;  i < n; i++)
            {
                if (array[i] == x)
                {
                    contador++;
                }  
            }
            Console.WriteLine($"A posição {x} aparece {contador} vezes" );
        }
  
    }

}

