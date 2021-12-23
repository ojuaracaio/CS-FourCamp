using System;
using System.Threading;

namespace Controle_Partidas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Juiz juiz = new Juiz("Carlos", 179, "Alta", "Sim");
            Bola bola = new Bola();
            Partida partida = new Partida();
            //bool opcaoBola, opcaoJuiz;

            //partida.bolaPresente();

            if (partida.bolaPresente() && partida.juizPresente())
            {
                partida.iniciaPartida();
                bola.chutar(10);
                bola.chutar(20);
                partida.encerraPartida();
                juiz.imprimeDados();
            } else
            {
                Console.WriteLine("Erro. Não foi possível iniciar a partida.");
            }

            return;
            

        }
    }
}
