using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ByteBank.Forum.ViewModels
{
    public class ContaVerificacaoDoisFatoresViewModel
    {
        [Required]
        [Display(Name = "Token de SMS")]
        public string Token { get; set; }

        [Display(Name = "Continuar logado")]
        public bool ContinuarLogado { get; set; }

        [Display(Name = "Lembrar deste computador")]
        public bool LembrarDesteComputador { get; set; }
    }
}