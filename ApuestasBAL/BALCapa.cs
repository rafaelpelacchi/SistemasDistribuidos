using System;
using ApuestasDAL;
using ApuestasDTO;

namespace ApuestasBAL
{
    public class BALCapa
    { 
        private DALCapaDB capaDAL = new DALCapaDB();

        public DTOUsuario obtenerInfoUsuario(string login)
        {
            return capaDAL.obtenerInfoUsuario(login);
        }
    }
}
