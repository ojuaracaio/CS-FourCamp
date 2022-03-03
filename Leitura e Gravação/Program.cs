using System;
using System.Collections.Generic;

namespace Leitura_e_Gravação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "../../../Estoque.csv";
            Leitor leitor = new Leitor();
            List<string> listaItens = leitor.Decodificar(leitor.LerArquivo(caminho));
            Console.WriteLine("Item\tFab.\tMat.\tPreço");
            for (int i = 0; i < (listaItens.Count/4); i++)
            {
                Console.WriteLine($"{listaItens[i]}-{listaItens[i+1]}-{listaItens[i+2]}-{listaItens[i+3]}");
            }
        }
    }
}
