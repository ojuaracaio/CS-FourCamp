using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_pt1
{
    internal interface ILeitura
    {
        public string[] Decodificar(string c);
        public string CarregarDados(string s);
    }
}
