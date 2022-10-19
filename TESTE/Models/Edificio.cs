using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TESTE.Models
{
    [Table("Edificios")]
    public class Edificio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome")]
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a quantidade de Blocos")]
        public int Blocos { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o número de Apartamentos")]
        public int Apartamentos { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar de Endereço")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Pais")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Numero")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Complemento")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CEP")]
        public string CEP { get; set; }


    }
}
