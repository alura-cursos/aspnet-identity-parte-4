using ByteBank.Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ByteBank.Forum.ViewModels
{
    public class UsuarioViewModel
    {
        public string Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public UsuarioViewModel() { }
        public UsuarioViewModel(UsuarioAplicacao usuario)
        {
            Id = usuario.Id;
            NomeCompleto = usuario.NomeCompleto;
            Email = usuario.Email;
            UserName = usuario.UserName;
        }
    }
}