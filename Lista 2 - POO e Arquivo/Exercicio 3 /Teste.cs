CLASSE TESTE using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicio3
{
public class Teste
{
public static void Main(string[] args)
{
AgendaTelefonica agenda= new AgendaTelefonica(50);


Console.WriteLine("Escolha uma opção:\n 1. Inserir um novo contato\n 2. Buscar um contato pelo nome \n 3. Imprimir todos os dados de todos os contatos da agenda telefônica \n 4. Encerrar programa");
int opcao = int.Parse(Console.ReadLine());
while(opcao != 4)
{
switch(opcao)
{
case 1:
Console.WriteLine("Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("E-mail: ");
string email = Console.ReadLine();
Console.WriteLine("Celular: ");
long celular = long.Parse(Console.ReadLine());
Console.WriteLine("Dia do aniversário: ");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Mês do aniversário: ");
int mes = int.Parse(Console.ReadLine());
Console.WriteLine();
Contato novoContato = new Contato(nome, email, celular, dia, mes);
agenda.InserirContato(novoContato);
break;


case 2:
Console.WriteLine("Qual nome você quer buscar? ");
string buscar = Console.ReadLine();


Contato contatoEncontrado = agenda.BuscarContato(buscar);
if(contatoEncontrado != null)
{
Console.WriteLine($"Contato encontrado: Nome: {contatoEncontrado.nome}, Celular: {contatoEncontrado.celular}, Email: {contatoEncontrado.email}, Aniversário: {contatoEncontrado.aniversario.dia}/{contatoEncontrado.aniversario.mes}");


}
else
{
Console.WriteLine("Não encontramos o: " + buscar);
}
break;
case 3:
agenda.ImprimirContatos();
break;


default:
Console.WriteLine("Opção inválida. Escolha uma opção válida");
break;
}


}
Console.ReadKey();
}


}
}
