using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Pensiones:Cuenta
    {
        //Se le heredan los atributos de la clase padre y tambien se le asignan sus propios atributos
        public string Vencimiento { get; set; }
        public double Cotizacion { get; set; }
        public string NcuentaOrigen { get; set; }
    }
}
