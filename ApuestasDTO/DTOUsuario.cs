using System;
namespace ApuestasDTO
{
    public class DTOUsuario
    {
        public String Login { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        public DTOUsuario(string login)
        {
            this.Login = login;   
        }
    }
}
