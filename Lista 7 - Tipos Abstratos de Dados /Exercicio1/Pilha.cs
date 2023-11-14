using System;


namespace Exercicio1
{
    public class Pilha
    {
        private Celula topo;
        private int contador;

        public Pilha()
        {
            topo = null;
        }

        public void Inserir(char c)
        {
            Celula tmp = new Celula();
            tmp.Prox = topo;
            topo = tmp;
            tmp = null;
            contador++;
        }

        public char Remover()
        {
            if (topo == null)
            {
                throw new Exception("Pilha vazia");
            }
            char elemento = topo.Elemento;
            Celula tmp = new Celula();
            tmp = topo;
            topo = tmp.Prox;
            tmp.Prox = null;
            tmp = null;

            contador--;
            return elemento;
        }


        public void Mostrar()
        {
            if (topo == null)
            {
                throw new Exception("Pilha vazia");
            }
            Console.WriteLine(" [");
            for (Celula i = topo; i != null; i = i.Prox)
            {
                Console.WriteLine(" " + i.Elemento);
            }
        }

        public int Count()
        {
            return contador;
        }

        public char Topo()
        {
            if (topo == null)
            {
                throw new Exception("Pilha vazia");
            }
            return topo.Elemento;
        }
    }
}
