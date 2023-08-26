using System;
using System.Globalization;

namespace Exercicio1
{

    public class Aluno
    {

        //atributos
        private string nome;
        private int idade;
        private double peso;
        private bool formando;
        private char sexo;

        public Aluno()
        {
        }


        //construtor
        public Aluno(string nome, int idade, double peso, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.sexo = sexo;
        }


        //getters e setters     
        public string Nome { get; set; }

        public int Idade { get; set; }

        public double Peso { get; set; }

        public char Sexo { get; set; }

        public bool Formado { get; set; }

    }
}
