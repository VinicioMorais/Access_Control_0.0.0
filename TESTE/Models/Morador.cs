using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TESTE.Models
{   
    [Table("Moradores")]
    public class Morador
    {   
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CPF")]
        public char Cpf { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o número do Apt")]
        public char Apt { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o número do Bloco")]
        public char Bloco { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o número de Dependentes")]
        public char Dependentes { get; set; }
    }
}
