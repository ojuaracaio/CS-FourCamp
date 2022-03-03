using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Petshop.Models
{
    [Table("TB_AnimalVeterinario")]
    public class AnimalVeterinario
    {
        public int AnimalVeterinarioId { get; set; }
        public Animal Animal { get; set; }

        public int AnimalId { get; set; }

        public Veterinario Veterinario { get; set; }

        public int VeterinarioId { get; set; }

        public DateTime Data { get; set; }

    }
}
