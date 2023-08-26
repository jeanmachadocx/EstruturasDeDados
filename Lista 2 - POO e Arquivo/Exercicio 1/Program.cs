using System;
/*No método Main:


• Depois, pergunte novamente ao usuário os valores da idade, do peso e se o aluno é formando.

Altere estes atributos com os parâmetros informados por meio dos métodos modificadores

(Set).

• Por fim, imprima novamente os valores dos atributos do objeto Aluno usando os métodos de

acesso (Get) de Aluno */


namespace Exercicio1

{

    public class Program

    {

        public static void Main(string[] args)

        {

            Aluno aluno1 = new Aluno();

            Console.WriteLine("Informe o nome:");

            string nome = Console.ReadLine();

            aluno1.Nome = nome;


            Console.WriteLine("Idade: ");

            int idade = int.Parse(Console.ReadLine());

            aluno1.Idade = idade;


            Console.WriteLine("Peso: ");

            double peso = double.Parse(Console.ReadLine());

            aluno1.Peso = peso;



            Console.WriteLine("Sexo M/F: ");

            char sexo = char.Parse(Console.ReadLine());

            aluno1.Sexo = sexo;


            Console.WriteLine("Você é formado? true || false");

            bool formado = bool.Parse(Console.ReadLine());

            aluno1.Formado = formado;


            Console.WriteLine();

            Console.WriteLine(aluno1.Nome);

            Console.WriteLine(aluno1.Idade);

            Console.WriteLine(aluno1.Peso);

            Console.WriteLine(aluno1.Sexo);

            Console.WriteLine(aluno1.Formado);



            //da idade, do peso e se o aluno é formando.

            Console.WriteLine("Digite uma nova idade: ");

            aluno1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite seu novo peso: ");

            aluno1.Peso = double.Parse(Console.ReadLine());


            Console.WriteLine("Formou? ");

            aluno1.Formado = bool.Parse(Console.ReadLine());


            Console.WriteLine(aluno1.Idade);

            Console.WriteLine(aluno1.Peso);

            Console.WriteLine(aluno1.Formado);


            Console.ReadKey();

        }

    }

}