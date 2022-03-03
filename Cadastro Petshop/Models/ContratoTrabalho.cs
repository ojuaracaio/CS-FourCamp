using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro_Petshop.Models
{
    [Table("TB_ContratoTrabalho")]
    public class ContratoTrabalho
    {
        public int ContratoTrabalhoId { get; set; }

        [Column("Dt_Contratacao", TypeName="Date"), Display(Name = "Data de Contratação"), DataType(DataType.Date)]
        public DateTime DataContratacao { get; set; }

        public TipoContrato Tipo { get; set; }

        public decimal Valor { get; set; }
    }
}
