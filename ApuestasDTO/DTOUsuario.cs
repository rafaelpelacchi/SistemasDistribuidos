using System;
namespace ApuestasDTO
{
    public class DTOUsuario
    {
        public String Login { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public DTOUsuario(string login)
        {
            this.Login = login;   
        }

        public DTOUsuario(string login,string password,string nombre, string apellido)
        {
            this.Login = login;
            this.Password = password;
            this.Nombre = nombre;
            this.Apellido = apellido;

        }
    }
}
