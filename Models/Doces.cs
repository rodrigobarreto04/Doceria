using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doceria.Models
{
    public class Doces
    {
        [Display(Name = "Código do Produto")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Doce_cd { get; set; }

        [Display(Name = "Tipo de doce")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(30, ErrorMessage = "Este campo deve conter no máximo 30 caracteres")]
        public string Doce_tipo { get; set; }

        [Display(Name = "Fabricante do doce")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Este campo deve conter no máximo 50 caracteres")]
        public string Doce_fornec { get; set; }

        [Display(Name = "Peso do doce (g)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Doce_peso { get; set; }

        [Display(Name = "Quantidade em estoque")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int Doce_est { get; set; }
    }
}