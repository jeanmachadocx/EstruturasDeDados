using System;


namespace Exercicio7
{
    public class ListaDupla
    {
        private CelulaDupla primeiro, ultimo;

        public ListaDupla()
        {
            primeiro = new CelulaDupla();
            ultimo = new CelulaDupla();
        }

        public void InserirInicio(int x)
        {
            CelulaDupla tmp = new CelulaDupla(x);
            tmp.Ant = primeiro;
            tmp.Prox = primeiro.Prox;
            primeiro.Prox = tmp;
            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }
           
            tmp = null;
        }
        public void InserirFim(int x)
        {
            ultimo.Prox = new CelulaDupla(x);
            ultimo.Prox.Ant = ultimo;
            ultimo = ultimo.Prox;
        }

        public void Inserir(int x, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                InserirInicio(x);
            }
            else
            {
                CelulaDupla i = primeiro;
                for (int j = 0; j < pos; j++, i = i.Prox) ;
                CelulaDupla tmp = new CelulaDupla(x);
                tmp.Ant = i;
                tmp.Prox = i.Prox;
                tmp.Ant.Prox = tmp.Prox.Ant = tmp;
                tmp = i = null;
            }
        }

        public int Tamanho()
        {
            int tam = 0;
            for (CelulaDupla i = primeiro; i != ultimo; i = i.Prox)
            {
                tam++;
            }
            return tam;
        }

        public int Remover(int pos)
        {
            int elemento, tamanho = Tamanho();
            if (primeiro == ultimo)
            {
                throw new Exception("Erro!");
            }
            else if (pos < 0 || pos >= tamanho)
            {
                throw new Exception("Erro!");
            }

            else
            {
                CelulaDupla i = primeiro.Prox;
                for (int j = 0; j < pos; j++, i = i.Prox) ;
                i.Ant.Prox = i.Prox;
                i.Prox.Ant = i.Ant;
                elemento = i.Elemento;
                i.Prox = i.Ant = null;
                i = null;
            }
            return elemento;
        }

        public int RemoverInicio()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            CelulaDupla tmp = primeiro;
            primeiro = primeiro.Prox;
            int elemento = primeiro.Elemento;
            tmp.Prox = primeiro.Ant = null;
            tmp = null;
            return elemento;
        }

        public int RemoverFim()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            int elemento = ultimo.Elemento;
            ultimo = ultimo.Ant;
            ultimo.Prox.Ant = null;
            ultimo.Prox = null;
            return elemento;
        }

        public void Mostrar()
        {
            Console.Write("[ ");
            for (CelulaDupla i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.Write(i.Elemento + " ");
            }
            Console.WriteLine("] ");
        }
