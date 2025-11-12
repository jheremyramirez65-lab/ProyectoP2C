using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPOOArchP2C
{
     public class Cliente
    {
        //PROPIEDADES
        public int IdCli { get; set; }
        public string NombreCli { get; set; }
        public  List<CuentaBancaria> lstCtas { get; set; }

        //CONSTRUCTORES
        public Cliente()
        {
            IdCli = 0;
            NombreCli = "No definido";
            lstCtas = new List<CuentaBancaria>();
        }
        public Cliente(int idC, string nomC)
        {
            IdCli = idC;
            NombreCli = nomC;
            lstCtas = new List<CuentaBancaria>();
        }
    }
}
