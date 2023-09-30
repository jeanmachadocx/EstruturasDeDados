using System;
using System.Collections.Generic;

namespace Exercicio3    
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insira a sequência: ");
            string sequencia = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach(char i in sequencia)
            {
                if (stack.Count > 0) // verificar se a pilha está vazia 
                {
                    if (i == '(' || i == '[')
                    {
                        stack.Push(i);
                    }
                    else if(i == ')')
                    {
                        if(stack.Count > 0 && stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("A pilha NÃO está formatada");
                        }
                    }
                    else if (i == ']')
                    {
                        if (stack.Count > 0 && stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            Console.WriteLine("A pilha NÃO está formatada");
                        }
                    }
                } 
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("A sequência está formatada");
            }


            Console.ReadKey();
        }
    }
}

