using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Celula
    {
        private char elemento;
        private Celula prox;

        public Celula(char elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public Celula()
        {
            this.elemento = 0;
            this.prox = null;
        }
        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
        public char Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }

    }
}

//3) CLASSE PILHA 

using System;
using System.Threading;

namespace Exercicio3
{
    class Pilha
    {
        private Celula topo;
        private int contador;
        public Pilha()
        {
            topo = null;
            contador = 0;
        }
        public void Inserir(int x)
        {
            Celula tmp = new Celula(x);
            tmp.Prox = topo;
            topo = tmp;
            tmp = null;
            contador++;
        }
        public int Remover()
        {
            if (topo == null)
                throw new Exception("Pilha vazia");
            int elemento = topo.Elemento;
            Celula tmp = topo;
            topo = topo.Prox;
            tmp.Prox = null;
            tmp = null;
            contador--;
            return elemento;
        }
        public void Mostrar()
        {
            Console.Write("[ ");
            for (Celula i = topo; i != null; i = i.Prox)
            {
                Console.Write(i.Elemento + " ");
            }
            Console.WriteLine("]");
        }

        public bool IsVazia()
        {
            if (topo != null)
            {
                return false;
            }

            return true;

        }

        public int Count()
        {
            return contador;
        }

        public char Topo()
        {
            if( topo == null)
            {
                throw new Exception("Pilha vazia ");
            }
            return topo.Elemento;
        }
    }
}

//3 MAIN
using System;
using System.Collections.Generic;

namespace Exercicio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira a sequência: ");
            string sequencia = Console.ReadLine();

            Pilha stack = new Pilha();

            foreach (char i in sequencia)
            {
                if (stack.Count() >= 0) 
                {
                    if (i == '(' || i == '[')
                    {
                        stack.Inserir(i);
                    }
                    else if (i == ')')
                    {
                        if (stack.Count()> 0 && stack.Topo() == '(')
                        {
                            stack.Remover();
                        }
                        else
                        {
                            Console.WriteLine("A pilha NÃO está formatada");
                        }
                    }
                    else if (i == ']')
                    {
                        if (stack.Count() > 0 && stack.Topo() == '[')
                        {
                            stack.Remover();
                        }
                        else
                        {
                            Console.WriteLine("A pilha NÃO está formatada");
                        }
                    }
                }
            }
            if (stack.Count() == 0)
            {
                Console.WriteLine("A sequência está formatada");
            }
            Console.ReadKey();
        }
    }
}
