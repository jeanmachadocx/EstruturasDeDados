using System;

namespace Produto
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            int opcao;
            Lista lista = new Lista(10);
            do
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine(" 1. Inserir um produto no final da lista");
                Console.WriteLine(" 2. Remover um produto específico da lista. ");
                Console.WriteLine(" 3. Listar os dados de todos os produtos ");
                Console.WriteLine(" 4. Pesquisar se um produto já consta na Lista");
                Console.WriteLine(" 5.  Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine();
                        Console.Write("Quantidade: ");
                        int quant = int.Parse(Console.ReadLine());
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine());
                        lista.InserirFim(new Produto(nome, quant, preco));
                        break;

                    case 2:
                        Console.WriteLine("Nome do produto a ser removido: ");
                        nome = Console.ReadLine();
                        Produto produtoRemovido = lista.RemoverItem(nome);
                        break;

                    case 3:
                        lista.Mostrar();
                        break;

                    case 4:
                        Console.WriteLine("Nome do produto a ser pesquisado: ");
                        nome = Console.ReadLine();

                        if (lista.Pesquisar(nome))
                        {
                            Console.WriteLine(" Produto encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Produto não encontrado ");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saindo");
                        break;

                    default:
                        Console.WriteLine("Comando inválido! ");
                        break;
                }

            } while (opcao != 5);
        }
    }
}

//2) CLASSE: LISTA 


using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Produto
{
    public class Lista
    {
        private Produto[] lista;
        private int n;

        public Lista(int tamanho)
        {
            lista = new Produto[tamanho];
            n = 0;
        }

        public void InserirFim(Produto x)
        {
            if (n >= lista.Length)
            {
                Console.WriteLine("Erro ao inserir");
            }
            lista[n + 1] = x;
            n++;
        }

        public Produto RemoverItem(string nome)
        {
            //var para teste 
            int pos = -1;

            //percorre a lista e valida se o nome aparece
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i].Nome == nome)
                {
                    pos = i;
                }
            }

            //nao achou retorna nulo
            if (pos == -1)
            {
                return null;
            }

            //se encontrar diminui o tamanho e salva a posicao
            Produto resp = lista[pos];
            n--;

            //percorre o vetor movimentando as pos 
            for (int i = pos; i < n; i++)
            {
                lista[i] = lista[i + 1];
            }

            return resp;
        }

        public void Mostrar()
        {
            Console.Write(" [ ");
            foreach (Produto x in lista)
            {
                Console.Write(x + " ");
            }
            Console.Write(" ]");
        }

        public bool Pesquisar(string nome)
        {
            int pos = -1;

            //percorre a lista e valida se o nome aparece
            for (int i = 0; i < n; i++)
            {
                if (lista[i].Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

//2) CLASSE: PRODUTO 
			using System;
using System.Collections.Generic;

namespace Produto
{
    public class Produto
    {
        private string nome;
        private int quant;
        private double preco;

        public Produto(string nome, int quant, double preco)
        {
            this.nome = Nome;
            this.quant = Quant;
            this.preco = Preco;
        }

        public string Nome{ get; set;}
        public int Quant { get; set; }
        public double Preco { get; set; }
    }
}
