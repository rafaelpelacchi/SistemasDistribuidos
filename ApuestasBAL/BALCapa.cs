using System;
using System.IO;
using System.Net;
using ApuestasDAL;
using ApuestasDTO;
using System.Net.Sockets;
using System.Text;
using System.Web.Script.Serialization;
using static ApuestasDTO.Constantes;

namespace ApuestasBAL
{
    public class BALCapa
    { 
        private DALCapaDB capaDAL = new DALCapaDB();

        public DTOUsuario obtenerInfoUsuario(string login)
        {
            return null;
        }

        public string ObtenerCriptomonedas(){
            String infoCriptomonedas = HttpGet((int)Ruta.Ruta_Criptomonedas);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Object objeto = ser.DeserializeObject(infoCriptomonedas);
            Console.Write(infoCriptomonedas);
            Console.Write(objeto);
            return infoCriptomonedas;
        }

        public bool crearUsuariosBal(DTOUsuario user)
        {
            DALCapaDB dal = new DALCapaDB();
            return dal.registrarUsuario(user);
            
        }

        private string HttpGet(int Ruta)
        {
            string respuesta = "jhb";
            WebRequest request = WebRequest.Create (obtenerRuta(Ruta));  
            //WebRequest request = WebRequest.Create ("http://192.168.1.7:8765/Middleware/data?password=sdgadhadvaervstbsdrfvserv");  
            request.Method = "POST";  
            string postData = "This is a test that posts this string to a Web server.";  
            byte[] byteArray = Encoding.UTF8.GetBytes (postData);  
            request.ContentType = "application/x-www-form-urlencoded";  
            request.ContentLength = byteArray.Length;  
            Stream dataStream = request.GetRequestStream ();  
            dataStream.Write (byteArray, 0, byteArray.Length);  
            dataStream.Close ();
            WebResponse response = request.GetResponse ();  
            Console.WriteLine (((HttpWebResponse)response).StatusDescription);  
            dataStream = response.GetResponseStream ();  
            StreamReader reader = new StreamReader (dataStream);  
            respuesta = reader.ReadToEnd ();   
            reader.Close ();  
            dataStream.Close ();  
            response.Close (); 
            return respuesta;
        }

        private String obtenerRuta(int opcion){
            String consulta = "";
            switch(opcion){
                case (int) Ruta.Ruta_Criptomonedas: { consulta = "http://192.168.1.7:8765/Middleware/data?market"; break; }
            }
            return consulta;
        }
    }
}
