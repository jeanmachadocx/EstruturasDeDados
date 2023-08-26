CLASSE AGENDA TELEFONICA 


using System;


namespace Exercicio3
{
public class AgendaTelefonica
{
private Contato[] agenda;
private int quantidade;


public AgendaTelefonica(int tamanho)
{
agenda = new Contato[tamanho];
quantidade = 0;
}


public void InserirContato(Contato novoContato)
{
if (quantidade < agenda.Length)
{
agenda[quantidade] = novoContato;
quantidade++;
}
else
{
Console.WriteLine("A agenda está cheia. Erro ao adicionar");
}
}
public int GetQuantidadeDeContatos()
{
return quantidade;
}


public Contato BuscarContato(string nome)
{
for (int i = 0; i < quantidade; i++)
{
if (agenda[i].nome == nome)
{
return agenda[i];
}
}
return null;
}


public void ImprimirContatos()
{
Console.WriteLine("Lista de contatos: ");
for (int i = 0; i < quantidade; i++)
{
Console.WriteLine("Nome: "+ agenda[i].nome+ " Celular: " + agenda[i].celular + " E-mail: " + agenda[i].email + " Aniversário: " + agenda[i].aniversario.dia + "/" + agenda[i].aniversario.mes);
}
}
}
}
