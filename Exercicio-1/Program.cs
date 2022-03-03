using System;
using System.IO;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader leitor = new StreamReader("../../../arquivo.txt")) //cria o leitor
            {
                string TextoDoArquivo = leitor.ReadLine();// lê a primeira linha do arquivo
                char[] ListaCaracteres = TextoDoArquivo.ToCharArray();// cria uma lista de caracteres com o texto do arquivo
                foreach(char caracter in ListaCaracteres)// itera pela lista de caracteres
                {
                    int ValorNumerico = (int)Convert.ToChar(caracter);// converte os caracteres para seu valor ascii
                    //Console.WriteLine(ValorNumerico);
                    if (ValorNumerico>=65 && ValorNumerico<=90 || ValorNumerico>=97 && ValorNumerico<=122) // quer dizer que é uma letra maiúscula ou minúscula
                    {
                        Console.Write(caracter);
                    }
                }
            }
        }
    }
}
