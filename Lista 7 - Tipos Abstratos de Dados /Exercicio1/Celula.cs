using System;
public class Celula
{
    private char elemento;
    private Celula prox;

    public Celula(char elemento)
    {
        this.elemento = elemento;
        this.prox = null;
    }

    public Celula()
    {
        this.elemento = ' ';
        this.prox = null;
    }

    public Celula Prox
    {
        get { return prox ; }
        set { prox = value; }
    }

    public char Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
