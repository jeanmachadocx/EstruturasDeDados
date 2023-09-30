using System;
using System.Collections.Generic;

namespace Exercicio5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
             string frase = "Laranja Banana uva banana uva banana";
             string [] palavras = frase.ToLower().Split(' ');

            foreach (var palavra  in palavras)
            {
                if (dicionario.ContainsKey(palavra)){
                    dicionario[palavra] += 1;
                }
                else
                {
                    dicionario[palavra] = 1;
                }
            }

            foreach (var palavra in dicionario)
            {
                Console.WriteLine($" Palavra: {palavra.Key}, aparece: {palavra.Value}");
            }

            Console.WriteLine($"Total de palavras {dicionario.Count}");

            Console.ReadKey();
        }
    }
}


