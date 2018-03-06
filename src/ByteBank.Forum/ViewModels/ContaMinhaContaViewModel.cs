using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ByteBank.Forum.ViewModels
{
    public class ContaMinhaContaViewModel
    {
        [Required]
        [Display(Name ="Nome completo")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Número de celular")]
        public string NumeroDeCelular { get; set; }

        [Display(Name = "Habilitar autenticação de dois fatores")]
        public bool HabilitarAutenticacaoDeDoisFatores { get; set; }

        public bool NumeroDeCelularConfirmado { get; set; }
    }
}