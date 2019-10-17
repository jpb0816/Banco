using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Cuenta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Interes { get; set; }


        public bool Ingreso()
        {



            return false;
        }

        public double Interesxmes(Cuenta c)
        {
            return c.Interes * c.Saldo;
            
        }

        public void ConsultarSaldo(Cuenta c)
        {//En este metodo se debe utilizar la clase cuenta para llamar los atributos aunque ya esten en esta clase 
         //porque tienen que ser llamados desde donde han estado siendo trabajdos
            Console.WriteLine("Su saldo actual es de: $"+c.Saldo);
        }

        public Cuenta Transferir(Cuenta origen,Cuenta destino, double cantidad)
        {
            origen.Saldo -= cantidad;
            destino.Saldo += cantidad;

            
            
        }

    }
}
