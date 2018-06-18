using System;
using System.Web.Mvc;
using Apuestas.App_Code;
using Apuestas.Models;
using ApuestasBAL;
using ApuestasDTO; 

namespace Apuestas.Controllers
{
    public class HomeController : Controller
    {

        BALCapa capaBal = new BALCapa();
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        // Este metodo es un ejemplo de como es la estructura del proyecto
        // Segun un String arma un 
        public JsonResult EjemploAutenticarUsuario(String login)
        {
            UsuarioViewModel infoUsuario =  AutoMapperConfiguration.mapper.Map<DTOUsuario,UsuarioViewModel>(capaBal.obtenerInfoUsuario(login));
           return Json(infoUsuario);
        }
    }
}
