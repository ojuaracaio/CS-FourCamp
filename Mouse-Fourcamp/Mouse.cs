using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse_Fourcamp
{
    public class Mouse
    {
        public int Id { get; set; }
        public List<Defeitos> Defeitos { get; set; }

        public Mouse(int id)
        {
            Id = id;
        }

        public void AdicionarDefeito(Defeitos defeito)
        {
            Defeitos.Add(defeito);
        }

    }
}
