using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1
{
    internal interface IGravacao
    {
        public string ConverterDados(Dictionary<string, TipoChavePix> dict);
        public void Salvar(string c, string v);
    }
}
