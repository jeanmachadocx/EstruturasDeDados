using System;


namespace Estacionamento
{
    public class Teste
    {
        public static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento("estacionamento", 10 );

            estacionamento.Estacionar("HKT0098");
            estacionamento.Estacionar("OLP4290");
            estacionamento.Estacionar("HJB0495");
            estacionamento.Estacionar("OWB3904");

            Console.WriteLine("Ocupação do estacionamento: ");
            estacionamento.ExibirOcupacaoEstacionamento();
            Console.WriteLine();


            Console.WriteLine("Está na vaga: " + estacionamento.ObterVagaOcupada("HKT0098"));
            Console.WriteLine();

            estacionamento.RetirarVeiculo("HKT0098");

            Console.WriteLine("Ocupação do estacionamento: ");
            estacionamento.ExibirOcupacaoEstacionamento();
            Console.WriteLine();


            estacionamento.Estacionar("HTP5619");
            estacionamento.Estacionar("BOL4861 ");
            estacionamento.Estacionar("HGT9436");

            Console.WriteLine("Quantidade de vagas livres: " + estacionamento.GetNumVagasLivres());

            Console.ReadKey();
        }
    }
}
