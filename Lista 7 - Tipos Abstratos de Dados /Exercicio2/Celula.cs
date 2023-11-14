using System;
namespace Exercicio2
{
    public class Celula
    {
        private int elemento;
        private Celula prox;

        public Celula(int elemento)
        {
            this.elemento = elemento;
            prox = null;
        }
        public Celula()
        {
            this.elemento = 0;
            this.prox = null;
        }

        public int Elemento
        {
            get { return elemento; }
            set { elemento = value; }
        }

        public Celula Prox
        {
            get { return prox; }
            set { prox = value; }
        }
    }
}
