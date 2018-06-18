using System;
namespace Apuestas.Models
{
    public class UsuarioViewModel
    {
        public String Login { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public UsuarioViewModel(string login)
        {
            this.Login = login;
        }
    }
}
