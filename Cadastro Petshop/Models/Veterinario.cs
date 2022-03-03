using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Petshop.Models
{
    [Table("TB_Veterinario")]
    public class Veterinario
    {
        [Column("Id")]
        public int VeterinarioId { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        [Required, MaxLength(40)]
        public string Especialidade { get; set; }

        public ContratoTrabalho ContratoTrabalho { get; set; }

        public int ContratoTrabalhoId { get; set; }

        public ICollection<AnimalVeterinario> AnimaisVeterinarios { get; set; }

    }
}
