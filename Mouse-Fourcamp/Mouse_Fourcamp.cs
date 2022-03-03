using System;
using System.Collections.Generic;

namespace Mouse_Fourcamp
{
    internal class Mouse_Fourcamp
    {
        static void Main(string[] args)
        {
            List<Mouse> Mouses = new List<Mouse>();
            int QtdDefeitos, IdMouse, IdDefeito;
            Mouse MouseAtual;
            do
            {
                Console.WriteLine("Insira o id do mouse (ou insira 0 para encerrar o programa):");
                IdMouse = int.Parse(Console.ReadLine());
                MouseAtual = new Mouse(IdMouse); //cria um mouse com o id passado

                Console.WriteLine($"Quantos defeitos o mouse {IdMouse} tem?");
                QtdDefeitos = int.Parse(Console.ReadLine()); // recebe quantos defeitos o mouse tem

                for (int i = 0; i < QtdDefeitos; i++)
                {
                    Console.WriteLine("Lista de defeitos:\n" +
                        "1. Necessita da Esfera\n" +
                        "2. Necessita de Limpeza\n" +
                        "3. Necessita de Troca do Cabo ou Conector\n" +
                        "4. Quebrado ou Inutilizado\n" +
                        "Insira qual defeito o mouse apresenta:");
                    IdDefeito = int.Parse(Console.ReadLine());

                    switch (IdDefeito)
                    {
                        case 1:
                            MouseAtual.AdicionarDefeito(Defeitos.NecessitaEsfera);
                            break;
                        case 2:
                            MouseAtual.AdicionarDefeito(Defeitos.NecessitaLimpeza);
                            break;
                        case 3:
                            MouseAtual.AdicionarDefeito(Defeitos.NecessitaCaboOuConector);
                            break;
                        case 4:
                            MouseAtual.AdicionarDefeito(Defeitos.QuebradoOuInutilizado);
                            break;
                    }
                }
                Mouses.Add(MouseAtual); // adiciona o mouse que acabou de ser criado na lista de mouses

            } while (IdMouse!= 0);

            Console.WriteLine("Relatório:");

        }
    }
}
