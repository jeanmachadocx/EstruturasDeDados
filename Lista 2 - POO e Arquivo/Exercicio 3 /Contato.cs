using System;




namespace Exercicio3
{
public class Contato
{
public string nome { get; set; }
public long celular { get; set; }
public string email { get; set; }
public Data aniversario { get; set; }


public Contato(string nome, string email, long celular, int diaAniversario, int mesAniversario)
{
this.nome = nome;
this.email = email;
this.celular = celular;
this.aniversario = new Data(diaAniversario, mesAniversario);
}


public Contato(string nome, int celular, Data aniversario)
{
this.nome = nome;
this.celular = celular;
this.aniversario= aniversario;
}
}
}
