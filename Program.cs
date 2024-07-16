using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Jokenpo.Models;
using System.Linq;

namespace Jokenpo 
{
    class Program 
    {

        static void Main (string[] args)
        {
            Dictionary<int,Jogada> jogada = new Dictionary<int, Jogada>
            {
                { 1, new Pedra() },
                { 2, new Papel() },
                { 3, new Tesoura() },
                { 4, new Lagarto() },
                { 5, new Spock() }
            };
            System.Console.WriteLine("Escolha sua jogada:\n1 - Pedra\n2 - Papel\n3 - Tesoura\n4 - Lagarto\n5 - Spock");
            int opcaoJogador = int.Parse(Console.ReadLine());
            if (jogada.ContainsKey(opcaoJogador))
            {
                //criei como chave para acessar o dicionario e atribuir a jogada na variavel jogadaJogador para comparar no meu metodo perde para
                Jogada jogadaJogador = jogada [opcaoJogador];
                //declarei a variavel jogador do tipo jogada para armazenar uma instancia das classes derivadas de jogada
                Random aleatorio = new Random();
                Jogada jogadaComputador = jogada [aleatorio.Next(1,6)];
                //maior ou igual a 1 ou menor que 6, por isso precisa ser um numero a mais
                System.Console.WriteLine($"Você escolheu {jogadaJogador.valor}\nO computador escolheu {jogadaComputador.valor}");
                //mais restritivo primeiro 
                if (jogadaJogador == jogadaComputador)
                {
                    System.Console.WriteLine("Deu empate!");
                }
                else if (jogadaComputador.PerdePara(jogadaJogador))
                {
                    System.Console.WriteLine("Você ganhou!");
                }
                else
                {
                    System.Console.WriteLine("Você perdeu!");
                }
            }
            else 
            {
                System.Console.WriteLine("Número inválido, escolha um valor de 1 a 5");
            }
        }
    }           
}


