using System;



    public class CelulaDupla
    {
    private int elemento;
    private CelulaDupla prox;
    private CelulaDupla ant;
    public CelulaDupla(int elemento)
    {
        this.elemento = elemento;
        this.ant = null;
        this.prox = null;
    }
    public CelulaDupla()
    {
        this.elemento = 0;
        this.ant = null;
        this.prox = null;
    }
    public CelulaDupla Prox
    {
        get { return prox; }
        set { prox = value; }
    }
    public CelulaDupla Ant
    {
        get { return ant; }
        set { ant = value; }
    }
    public int Elemento
    {
        get { return elemento; }
        set { elemento = value; }
    }
}
