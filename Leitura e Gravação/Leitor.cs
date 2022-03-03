using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitura_e_Gravação
{
    public class Leitor
    {
        public Leitor()
        {
                
        }

        public string LerArquivo(string caminho)
        {
            using (StreamReader sr = new StreamReader(caminho))
            {
                sr.ReadLine();// desconsidera a primeira linha (cabeçalho)
                return sr.ReadToEnd();
            }
                
        }

        public List<string> Decodificar(string textoCru)
        {
            List<string> listaValores = new List<string>();
            string[] linhas = textoCru.Split('\n');
            foreach(string linha in linhas)
            {
                string[] valores = linha.Split(';');
                foreach (string item in valores)
                {
                    listaValores.Add(item);
                }
            }
            return listaValores;
        }

    }
}
