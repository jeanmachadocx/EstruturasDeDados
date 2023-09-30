using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a operação na notação polonesa reversa: ");
            string notacaoPolonesa = Console.ReadLine();
            string[] tokens = notacaoPolonesa.Split(' ');

            Stack<double> stack = new Stack<double>();
            double resultado;


            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("Expressão inválida");
                        return;
                    }

                    double num2 = stack.Pop();
                    double num1 = stack.Pop();

                    switch (token)
                    {
                        case "+":

                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            resultado = num1 + num2;
                            Console.WriteLine(resultado);
                            stack.Push(resultado);
                            break;

                        case "-":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            resultado = num1 - num2;
                            Console.WriteLine(resultado);
                            stack.Push(resultado);
                            break;

                        case "*":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            resultado = num1 * num2;
                            Console.WriteLine(resultado);
                            stack.Push(resultado);
                            break;
                        case "/":
                            num1 = stack.Pop();
                            num2 = stack.Pop();
                            resultado = num1 / num2;
                            Console.WriteLine(resultado);
                            stack.Push(resultado);
                            break;

                        default:
                            Console.WriteLine("Expressão inválida");
                            break;
                    }

                    if (stack.Count == 1)
                    {
                        resultado = stack.Pop();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}


