using System;
using Npgsql;
namespace ApuestasDAL
{
    public class DALConectorDB
    {
        public DALConectorDB()
        {
            NpgsqlConnection cn = new NpgsqlConnection("SERVER=localhost; UID=postgres;PWD=damaris;DATABASE=ProyectoAsistenciaCCB;");

            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO reportes VALUES(?, ?, ?, ?, ?)", cn);

        }
    }
}
