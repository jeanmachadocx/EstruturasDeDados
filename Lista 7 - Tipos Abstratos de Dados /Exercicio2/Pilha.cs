using System;


namespace Exercicio2
{
    public class Pilha
    {
        private Celula topo;

        public Pilha()
        {
            this.topo = null;
        }

        public void Inserir(int x)
        {
            Celula tmp = new Celula(x);
            tmp.Prox = topo;
            topo = tmp;
            tmp = null;
        }

        public void Mostrar()
        {
            if(topo == null)
            {
                throw new Exception("Pilha vazia");
            }
            for (Celula i = topo; i!= null; i= i.Prox)
            {
                Console.Write(i.Elemento + " ");
            }
        }
    }
}
