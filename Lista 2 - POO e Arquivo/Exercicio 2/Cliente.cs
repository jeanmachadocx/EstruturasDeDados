using System;

namespace Exercicio2
{
    public class Cliente
    {
       
        private int codigo;
        private string nome;
        private bool eClienteEspecial;
        private double limiteCredito;
        public Cliente(int codigo, string nome)
        {
            this.codigo = codigo; 
            this.nome = nome;
            limiteCredito = 0; 
            eClienteEspecial = false;
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public bool AtualizarLimite(double valor)
        {
            if(eClienteEspecial == true)
            {
                limiteCredito = valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public void AtualizarCategoria(bool valor) 
        {
            eClienteEspecial = valor;

            if(valor == false)
            {
                limiteCredito = 0;
            }
        }
    }
}
