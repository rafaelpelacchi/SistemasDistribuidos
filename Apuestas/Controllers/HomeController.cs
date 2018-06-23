using System;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
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

        public JsonResult Ingresar(String login,String Password)
        {
            String Result = capaBal.ObtenerCriptomonedas();
            UsuarioViewModel infoUsuario = AutoMapperConfiguration.mapper.Map<DTOUsuario, UsuarioViewModel>(capaBal.obtenerInfoUsuario(login));
            return this.Json("you result", JsonRequestBehavior.AllowGet);
        }

        public ActionResult CrearUsuario(){
            return RedirectToAction("CrearUsuarios", "Usuarios");
        }

        public String eppe() { return "Rafa"; }
    }
}
