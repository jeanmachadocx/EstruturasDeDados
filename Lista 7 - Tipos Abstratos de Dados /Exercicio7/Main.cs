using Exercicio7;
using System;



public class Program
{
    public static void Main(string[] args)
    {
        ListaDupla listaDupla = new ListaDupla();
        listaDupla.Inserir(3,0);
        listaDupla.InserirFim(5);
        listaDupla.InserirFim(7);

        listaDupla.Mostrar();

        listaDupla.RemoverInicio();
        listaDupla.Mostrar();

        listaDupla.RemoverFim();
        listaDupla.Mostrar();

        listaDupla.Inserir(6, 2);
        listaDupla.Mostrar();   

        Console.ReadLine();

    }
}
