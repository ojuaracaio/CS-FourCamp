using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Petshop.Models
{
    [Table("TB_Plano")]
    public class Plano
    {
        [Column("Id")]
        public int PlanoId { get; set; }

        [Required, MaxLength(80)]
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public bool Disponivel { get; set; }

        public ICollection<Animal> Animais { get; set; }
    }
}
