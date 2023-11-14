using System;

namespace Exercicio3
{
    public class Celula
    {
        public Arquivo Dado { get; set; }
        public Celula Prox { get; set; }

        public Celula() { }

        public Celula(Arquivo arquivo)
        {
            Dado = arquivo;
        }
    }
}
