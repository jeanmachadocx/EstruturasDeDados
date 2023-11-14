using System;
namespace Exercicio3
{
    public class Fila
    {
        private Celula primeiro, ultimo;

        public Fila()
        {
            primeiro = new Celula();
            ultimo = new Celula();
        }

        public void Inserir(string nome, int tamanho)
        {
            Arquivo arquivo = new Arquivo(nome, tamanho);

            ultimo.Prox = new Celula(arquivo);
            ultimo = ultimo.Prox;
        }

        public Arquivo Remover()
        {
            if (primeiro == ultimo)
            {
                throw new Exception("Erro ao remover");
            }

            Celula tmp = primeiro.Prox;
            primeiro = tmp.Prox;
            Arquivo dado = tmp.Dado;
            Arquivo removido = dado;
            tmp = null;
            
            return tmp.Dado;
        }

        public void Mostrar()
        {
            for (Celula i = primeiro.Prox; i != null; i = i.Prox)
            {
                Console.Write(i.Dado + " ");
            }
        }
    }
}
