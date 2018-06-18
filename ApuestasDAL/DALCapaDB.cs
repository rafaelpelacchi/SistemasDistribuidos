using System;
using ApuestasDTO;

namespace ApuestasDAL
{
    public class DALCapaDB
    {
        public DTOUsuario obtenerInfoUsuario(String login){
            DTOUsuario usuarioRetorno = new DTOUsuario(login);

            //Aca hacer la conexion a la base de datos y llenar al usuario con sus datos
            usuarioRetorno.Nombre = "Usuario 1";
            usuarioRetorno.Apellido = "Usuario 1";

            return usuarioRetorno;
        }
    }
}
