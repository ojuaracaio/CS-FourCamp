using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Petshop.Models
{
    [Table("TB_Animal")]
    public class Animal
    {
        [HiddenInput]
        public int AnimalID { get; set; }

        [MaxLength(55)]
        public string Nome { get; set; }

        [Display(Name="Espécie"), Required]
        public Especies Especie { get; set; }

        public int? Idade { get; set; }

        [Display(Name ="Data de Nascimento"), DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        public double Peso { get; set; }

        [Required]
        public bool Castrado { get; set; }

        public Plano Plano { get; set; }

        public int? PlanoId { get; set; }

        public ICollection<AnimalVeterinario> AnimaisVeterinarios { get; set; }
    }
}
