using System;
using System.Collections.Generic;


    public class Program
    {
        public static void Main(string[] args)
        {
            List <int> relogio = new List<int>();
            int opcao;
            do
            {
                Console.WriteLine("Escolha uma opção: \n ");
                Console.WriteLine(" 1) Inserir um tempo no início da lista");
                Console.WriteLine(" 2) Inserir um tempo no final da lista");
                Console.WriteLine(" 3) Inserir um tempo numa posição específica da lista");
                Console.WriteLine(" 4) Remover o primeiro tempo da lista (Imprimir o tempo removido)");
                Console.WriteLine(" 5) Remover o último tempo da lista (Imprimir o tempo removido)");
                Console.WriteLine(" 6) Remover um tempo de uma posição específica na lista (O usuário deve informar a posição do tempo a ser");
                Console.WriteLine(" 7) Remover um tempo específico da lista (O usuário deve informar o tempo a ser removido)");
                Console.WriteLine(" 8) Pesquisar quantas vezes um determinado tempo consta na lista (O usuário deve informar o tempo a ser pesquisado)");
                Console.WriteLine(" 9) Mostrar todos os tempos da lista");
                Console.WriteLine(" 10) Mostrar todos os tempos da lista em ordem crescente ");
                Console.WriteLine(" 11) Mostrar todos os tempos da lista em ordem decrescente");
                Console.WriteLine(" 12) Encerrar o programa!");


                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Informe um tempo que deseja registrar: ");
                        int tempo= int.Parse(Console.ReadLine());
                        relogio.Insert(0, tempo);

                        break;

                    case 2:
                        Console.WriteLine("Informe um tempo que deseja registrar: ");
                        int tempoFinal = int.Parse(Console.ReadLine());
                        relogio.Add(tempoFinal);
                        break;

                    case 3:
                        Console.WriteLine("Informe a posição: ");
                        int posicao = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um tempo que deseja registrar: ");
                        int tempoNovo = int.Parse(Console.ReadLine());

                        relogio.add(tempoNovo);
                        break;

                    case 4:
                        if (relogio.Count > 0)
                        {
                            Console.WriteLine("Tempo que foi removido: " + relogio[0]);
                            relogio.RemoveAt(0);
                            foreach (int s in relogio)
                                Console.WriteLine(s);
                        }
                        else
                        {
                            Console.WriteLine("A lista está vazia!");
                        }
                        break;

                    case 5:
                        if (relogio.Count > 0)
                        {
                            Console.WriteLine("Tempo que foi removido: " + relogio[relogio.Count - 1]);
                            relogio.RemoveAt(relogio.Count - 1);
                        }
                        else
                        {
                            Console.WriteLine("A lista está vazia!");
                        }

                        break;

                    case 6:
                        Console.WriteLine("Escolha uma posição para exlcuir: ");
                        int posicaoRemover = int.Parse(Console.ReadLine());
                        relogio.RemoveAt(posicaoRemover);
                        foreach (int s in relogio)
                            Console.WriteLine(s);
                     break;

                    case 7:
                        Console.WriteLine("Informe o tempo a ser removido: ");
                        int tempoRemover = int.Parse(Console.ReadLine());
                        
                        bool result = relogio.Remove(tempoRemover);
                        if (result)
                            Console.WriteLine("Removido com sucesso!!");
                        else
                            Console.WriteLine("Não foi possivel excluir o tempo " + tempoRemover);
                        break;

                    case 8:
                        Console.WriteLine("Informe o tempo que deseja verificar");
                        int buscarTempo = int.Parse(Console.ReadLine());

                        int contador = 0; 

                        for(int i =0; i< relogio.Count; i++)
                        {
                            if (relogio[i] == buscarTempo)
                            {
                                contador++;
                            }
                        }

                        Console.WriteLine($" O tempo: {buscarTempo} aparece {contador} vezes "); 


                    break;


                    case 9:
                        
                        foreach(int x in relogio)
                        {
                            Console.WriteLine(x);
                        }
                    break;

                    case 10:
                        relogio.Sort();
                        foreach (var  x in relogio)
                        {
                            Console.WriteLine(x);
                        }
                     break;

                    case 11:

                        relogio.Sort((a, b) => b.CompareTo(a));
                        foreach (var x in relogio)
                        {
                            Console.WriteLine(x);
                        }
                    break;


                    case 12:

                        Console.WriteLine("Encerrando o programa! ");
                        break; 

                        default: 
                        Console.WriteLine("Opção inválida!"); 
                        break; 
                }


            } while (opcao != 12);
        }
    }
}

