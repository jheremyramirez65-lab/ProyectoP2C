using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPOOArchP2C
{
    public class CuentaBancaria
    {
        //PROPIEDADES
        public int IdCta { get; set; }
        public double MontoCta { get; set; }
        //CONSTRUCTORES
        public CuentaBancaria()
        {
            IdCta = 0;
            MontoCta = 0;
        }
        public CuentaBancaria(int idCta, double monto)
        {
            IdCta = idCta;
            MontoCta = monto;
        }
    }
}
