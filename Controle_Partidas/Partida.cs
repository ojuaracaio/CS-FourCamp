using System;

public class Partida
{
    //private bool isBolaPresente, isJuizPresente;
    private string opcaoBola, opcaoJuiz;
    const int TEMPOLIMITE = 110;
	public Partida()
	{
        Console.WriteLine("Bem-vindo ao gerenciador de partida.");
	}

    public Partida(string bola, string juiz)
    {
        opcaoBola = bola;
        opcaoJuiz = juiz;
        Console.WriteLine("Bem-vindo ao gerenciador de partida.");
    }
	public bool isValida(bool bola, bool juiz)
    {
		if (bola && juiz)
        {
            return true;
        }
        Console.WriteLine("Erro. Não foi possível iniciar a partida.");
        return false;
    }

	public bool bolaPresente()
    {
        while (true)
        {
            Console.WriteLine("A bola está em campo? (s)im ou (n)ão?");
		    opcaoBola = Console.ReadLine();
		    if (opcaoBola == "s" || opcaoBola == "S")
            {
			    //isBolaPresente = true;
                return true;
            } else if (opcaoBola == "n" || opcaoBola == "N")
            {
                Console.WriteLine("Não é possível jogar sem bola.");
			    //isBolaPresente = false;
                return false;
            } else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
        
    }

    public bool juizPresente()
    {
        while (true)
        {
            Console.WriteLine("O juiz está em campo? (s)im ou (n)ão?");
            opcaoJuiz = Console.ReadLine();
            if (opcaoJuiz == "s" || opcaoJuiz == "S")
            {
                //isJuizPresente = true;
                return true;
            }
            else if (opcaoJuiz == "n" || opcaoJuiz == "N")
            {
                Console.WriteLine("Não é possível jogar sem juiz.");
                //isJuizPresente = false;
                return false;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }

    }

    public void iniciaPartida()
    {
        Console.WriteLine("Partida iniciada.");
        for (int i = 0; i < TEMPOLIMITE; i++)
        {
            Console.Write("-");
            System.Threading.Thread.Sleep(25);
        }
        Console.WriteLine();
    }

    public void encerraPartida()
    {
        Console.WriteLine("Partida encerrada.");
    }
}
