using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Fila
    {
        private Celula primeiro;
        private Celula ultimo;

        public Fila()
        {
            primeiro = new Celula();
            ultimo = primeiro;
        }

        public void Inserir(int matricula)
        {
            ultimo.Prox = new Celula(matricula);
            ultimo = ultimo.Prox;
        }

        public int Remover()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro ao remover ");
            }
            Celula tmp = primeiro;
            primeiro = primeiro.Prox;
            int elemento = primeiro.Elemento;
            tmp = tmp.Prox = null;
            return elemento;
        }

        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.Write(i.Elemento + " ");
            }
            Console.WriteLine();
        }

        public bool Pesquisar(int matricula)
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                if (i.Elemento == matricula)
                {
                    return true;
                }
            }
            return false;

        }

    }
}
