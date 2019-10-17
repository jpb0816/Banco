using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Cuentaahorro:Cuenta
    {
        public DateTime Vencimiento { get; set; }

        public double IngresoporMes()
        {
            return 0;
        }
    }
}
