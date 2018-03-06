using ByteBank.Forum.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ByteBank.Forum.ViewModels
{
    public class UsuarioEditarFuncoesViewModel
    {
        public string Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }

        public List<UsuarioFuncaoViewModel> Funcoes { get; set; }

        public UsuarioEditarFuncoesViewModel() { }

        public UsuarioEditarFuncoesViewModel(UsuarioAplicacao usuario, RoleManager<IdentityRole> roleManager)
        {
            Id = usuario.Id;
            NomeCompleto = usuario.NomeCompleto;
            Email = usuario.Email;
            UserName = usuario.UserName;

            Funcoes =
                roleManager
                    .Roles
                    .ToList()
                    .Select(funcao =>
                        new UsuarioFuncaoViewModel
                        {
                            Nome = funcao.Name,
                            Id = funcao.Id
                        })
                    .ToList();

            foreach (var funcao in Funcoes)
            {
                var usuarioPossuiRole = usuario.Roles.Any(
                        usuarioRole => usuarioRole.RoleId == funcao.Id
                    );

                funcao.Selecionado = usuarioPossuiRole;
            }
        }
    }
}