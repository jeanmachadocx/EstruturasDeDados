using System;

    public class Program
    {
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira a sequência: ");
        string sequencia = Console.ReadLine();

        Pilha stack = new Pilha();
        bool bemFormada = true;

        foreach (char i in sequencia)
        {
            if (i == '(' || i == '[')
            {
                stack.Inserir(i);
            }
            else if (i == ')')
            {
                if (stack.Count() == 0 || stack.Topo() != '(')
                {
                    bemFormada = false;
                    break;  // Sair do loop se a sequência estiver malformada
                }
                stack.Remover();
            }
            else if (i == ']')
            {
                if (stack.Count() == 0 || stack.Topo() != '[')
                {
                    bemFormada = false;
                    break;  // Sair do loop se a sequência estiver malformada
                }
                stack.Remover();
            }
        }

        if (bemFormada && stack.Count() == 0)
        {
            Console.WriteLine("A sequência está formatada");
        }
        else
        {
            Console.WriteLine("A sequência não está formatada");
        }

        Console.ReadKey();
    }
}

