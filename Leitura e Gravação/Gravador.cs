using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitura_e_Gravação
{
    public class Gravador
    {
        public string Cabecalho { get; set; }
        public string Caminho { get; set; }
        public Gravador()
        {

        }
        public Gravador(string caminho)
        {
            Caminho = caminho;
        }

        public void EscreverArquivo(string caminho, string dados)
        {
            using (StreamWriter sw = new StreamWriter(caminho))
            {
                sw.Write(dados);
            }
        }
        public void EscreverArquivo(string dados)
        {
            using (StreamWriter sw = new StreamWriter(Caminho))
            {
                sw.Write(dados);
            }
        }

        public string CodificarString(List<string> lista)
        {
            string retorno = string.Empty;
            foreach (string str in lista)
            {
                retorno += str + ";";
            }
            return retorno;
        }
    }
}
