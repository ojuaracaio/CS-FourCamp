using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BD_Exemplo.Models
{
    [Table("Tbl_Animal")]
    public class Animal
    {
        [Column("Id")]
        public int AnimalId { get; set; }

        [MaxLength(50)]
        public string Nome { get; set;}

        [Column("Dt_Nascimento"), Required]
        public DateTime DataNascimento { get; set; }

        public float Peso { get; set; }

        [Required]
        public Especie Especie { get; set; }

        
        public bool Castrado { get; set; }
    }
}
