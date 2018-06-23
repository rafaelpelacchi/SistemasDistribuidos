using System;
using System.Collections.Generic;

namespace ApuestasDTO
{
    public class DTOListaCriptomonedas
    {
        DTOCriptomoneda BitCoin;
        DTOCriptomoneda Ethereum;
        DTOCriptomoneda Ripple;
        DTOCriptomoneda BitcoinCash;
        List<DTOCriptomoneda> lista;

        public String Nombre { get; set; } 


    }
}
