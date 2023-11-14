using System;

namespace Exercicio5
{
    public class Celula
    {
        private Celula prox;

        private int elemento;

        public Celula()
        {
            this.elemento = 0;
            this.prox = null;
        }

        public Celula(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
        public int Elemento { get; set; }
        public Celula Prox { get; set; }

    }
}

