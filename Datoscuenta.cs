using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Datoscuenta
    {
        //Se crearon metodos tipo lista para darles valor a los atributos de las cuentas, al hacer un metodo tipo lista
        //se debe darle el nombre de la clase con la que se quiere trabajar
        public List<Pensiones> ListaP()
        {
            List<Pensiones> lista = new List<Pensiones>();

            lista.Add(new Pensiones { Numero = 0781, Titular = "Jorge", Saldo = 20500, Interes = .5, Vencimiento = "30/03/2050", Cotizacion = 500, NcuentaOrigen = "9634" });
            lista.Add(new Pensiones { Numero = 2367, Titular = "Alejandro", Saldo = 34000, Interes = .5, Vencimiento = "05/08/2030", Cotizacion = 450, NcuentaOrigen = "0923" });
            lista.Add(new Pensiones { Numero = 3478, Titular = "Manuel", Saldo = 23000, Interes = .5, Vencimiento = "10/06/2035", Cotizacion = 500, NcuentaOrigen = "8076" });
            lista.Add(new Pensiones { Numero = 8954, Titular = "Oscar", Saldo = 30000, Interes = .5, Vencimiento = "25/02/2025", Cotizacion = 500, NcuentaOrigen = "2398" });
            lista.Add(new Pensiones { Numero = 5489, Titular = "Marcos", Saldo = 40000, Interes = .5, Vencimiento = "18/07/2040", Cotizacion = 500, NcuentaOrigen = "9087" });
            return lista;
        }

        public List<Cuentacorriente> ListaCC()
        {
            List<Cuentacorriente> lista = new List<Cuentacorriente>();
            //poniendo el comando lista.add podemos darle valores de manera mas sencilla a los atributos
            lista.Add(new Cuentacorriente { Numero = 0945, Titular = "Manuel", Saldo = 15000, Interes = .4 });
            lista.Add(new Cuentacorriente { Numero = 9834, Titular = "Juan", Saldo = 15500, Interes = .4 });
            lista.Add(new Cuentacorriente { Numero = 0834, Titular = "Alex", Saldo = 14000, Interes = .4 });
            lista.Add(new Cuentacorriente { Numero = 0734, Titular = "Arturo", Saldo = 16000, Interes = .4 });
            lista.Add(new Cuentacorriente { Numero = 0932, Titular = "Carlos", Saldo = 23000, Interes = .4 });

            return lista;
        }

        public List<Cuentaahorro> ListaCA()
        {
            List<Cuentaahorro> lista = new List<Cuentaahorro>();
            lista.Add(new Cuentaahorro { Numero = 9238, Titular = "Jose", Saldo = 4500, Interes = .6, Vencimiento = Convert.ToDateTime("25/05/2025") });
            lista.Add(new Cuentaahorro { Numero = 0912, Titular = "Javier", Saldo = 7500, Interes = .6, Vencimiento = Convert.ToDateTime("21/04/2025") });
            lista.Add(new Cuentaahorro { Numero = 9238, Titular = "Daniel", Saldo = 8500, Interes = .6, Vencimiento = Convert.ToDateTime("15/03/2025") });
            lista.Add(new Cuentaahorro { Numero = 9238, Titular = "Alexis", Saldo = 6500, Interes = .6, Vencimiento = Convert.ToDateTime("12/07/2025") });
            lista.Add(new Cuentaahorro { Numero = 9238, Titular = "Martin", Saldo = 5500, Interes = .6, Vencimiento = Convert.ToDateTime("19/06/2025") });
            return lista;
        }
    }
}
