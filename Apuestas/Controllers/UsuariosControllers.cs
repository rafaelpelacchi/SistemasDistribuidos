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
    public class UsuariosController : Controller
    {

        BALCapa capaBal = new BALCapa();
        public ActionResult CrearUsuarios(String usuario, String password, String nombre, String apellido){
        DTOUsuario user = new DTOUsuario(usuario,password,nombre,apellido);
            return View();
        }




    }
}
