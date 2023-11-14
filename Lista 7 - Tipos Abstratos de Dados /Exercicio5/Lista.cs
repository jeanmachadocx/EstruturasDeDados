using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio5
{
    public class Lista
    {
        private Celula primeiro;
        private Celula ultimo;
        private int tamanho;

        public Lista()
        {
            primeiro = new Celula();
            ultimo = primeiro;
            tamanho = 0;
        }

        public void InserirInicio(int x)
        {
            Celula tmp = new Celula(x);
            tmp.Prox = primeiro.Prox;
            primeiro.Prox = tmp;

            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }
            tmp = null;
            tamanho++;
        }

        public void InserirFim(int x)
        {
            Celula tmp = new Celula(x);
            ultimo.Prox = tmp;
            ultimo = ultimo.Prox;
            tmp = null;
            tamanho++;
        }

        public void Inserir(int x, int pos)
        {
            if (pos < 0 || pos > tamanho)
            {
                throw new Exception("Posição inválida ");
            }
            else if (pos == 0) InserirInicio(x);
            else if (pos == tamanho) InserirFim(x);
            else
            {
                Celula i = primeiro;
                for (int j = 0; j < pos; j++, i = i.Prox) ;

                Celula tmp = new Celula(x);
                tmp.Prox = i.Prox;
                i.Prox = tmp;

                tmp = i = null;
                tamanho++;
            }
           
        }

        public int RemoverInicio()
        {
            if (primeiro == ultimo)
                throw new Exception("Não pode remover, lista vazia");

            int elemento = primeiro.Prox.Elemento; 
            primeiro = primeiro.Prox;

            tamanho--;
            return elemento;
        }

        public int RemoverFim()
        {
            if (primeiro == ultimo)
                throw new Exception("Não pode remover, lista vazia");
            Celula i = primeiro;
            for (int j = 0; j < tamanho - 1; i = i.Prox, j++) ;
            Celula tmp = new Celula();
            tmp = ultimo;
            int elemento = ultimo.Elemento;
            ultimo = i;
            ultimo.Prox = null;
            tamanho--;
            return elemento;
        }

        public int Remover(int x)
        {
            if (primeiro == ultimo)
                throw new Exception("Não pode remover, lista vazia");
            Celula i = primeiro;
            if (primeiro.Elemento == x)
            {
                int remove = primeiro.Elemento;
                primeiro = primeiro.Prox;
                tamanho--;
                return remove;
            }

            while (i.Prox != null && i.Prox.Elemento != x)
            {
                i = i.Prox;
            }

            if (i.Prox == null)
            {
                throw new Exception("Elemento não encontrado ");
            }

            int remover = i.Prox.Elemento;
            i.Prox = i.Prox.Prox;

            if (i.Prox == null)
            {
                ultimo = i;
            }
            tamanho--;
            return remover;
        }

        public int Contar(int x)
        {
            int contador = 0;
            if (primeiro == ultimo)
            {
                throw new Exception("Não pode remover, lista vazia");
            }
            Celula i;
            for(i = primeiro; i != null; i = i.Prox)
            {
                if(i.Elemento == x)
                {
                    contador++;
                }
            }
            return contador;
        }

        public void Mostrar()
        {
            Console.WriteLine();
            if (primeiro == ultimo)
            {
                throw new Exception("Não pode remover, lista vazia");
            }
            Celula i;
            for(i = primeiro; i!= null; i = i.Prox)
            {
                Console.Write(i.Elemento + " ");
            }
        }
    }
}
