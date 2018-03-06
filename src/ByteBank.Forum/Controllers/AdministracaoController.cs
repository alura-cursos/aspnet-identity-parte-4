using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ByteBank.Forum.Controllers
{
    [Authorize(Roles = RolesNomes.ADMINISTRADOR)]
    public class AdministracaoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}