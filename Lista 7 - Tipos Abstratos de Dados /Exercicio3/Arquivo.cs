using System;
using System.Collections.Generic;


namespace Exercicio3
{
    public class Arquivo
    {
            public string nome { get; set; }
            public int tamanho { get; set; } 

            public Arquivo(string nome, int tamanho)
            {
                this.nome = nome;
            this.tamanho = tamanho;
            }

        public int Tamanho
		{
			get { return tamanho; }
			set { tamanho = value; }
		}
	}
}
