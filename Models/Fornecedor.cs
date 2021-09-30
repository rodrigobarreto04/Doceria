using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doceria.Models
{
    public class Fornecedor
    {
        [Display(Name = "Código do Fornecedor")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Forn_cod { get; set; }

        [Display(Name = "Nome do Fornecedor")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Este campo deve conter no máximo 50 caracteres")]
        public string Forn_nome { get; set; }

        [Display(Name = "Endereço do Fornecedor")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Este campo deve conter no máximo 50 caracteres")]
        public string Forn_endereco { get; set; }

        [Display(Name = "Telefone do Fornecedor")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(11, ErrorMessage = "Este campo deve conter no máximo 11 caracteres")]
        [RegularExpression(@"^\d{2}\ \d{5}-\d{4}$", ErrorMessage = "Digite um telefone válido!")]
        public string Forn_telefone { get; set; }

        [Display(Name = "Email do Fornecedor")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Este campo deve conter no máximo 60 caracteres")]
        public string Forn_email { get; set; }

    }
}