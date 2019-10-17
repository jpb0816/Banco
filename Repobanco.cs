using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Repobanco
    {
        List<Pensiones> pensiones = new List<Pensiones>();
        List<Cuentacorriente> cuentacorriente = new List<Cuentacorriente>();
        List<Cuentaahorro> cuentaahorro = new List<Cuentaahorro>();
        Cuenta cuenta = new Cuenta();
        List<Cuenta> cuentas = new List<Cuenta>();
        Datoscuenta dc = new Datoscuenta();

        public Repobanco()
        {
            
        }

        internal void Principal()
        {
            Console.WriteLine("Bienvenidos a el banco mi casita");
            Menu();

            Console.ReadKey();

        }

        public void Menu()
        {
            //En el menu se mandan a llamar los metodos , dependiendo de la opcion que ingrese, el usuario ingresara informacion sobre su cuenta 
            //y elegira la opcion que quiera realizar con su informacion ingresada

           


            Console.WriteLine("Ingrese la opcion correcta");
            Console.WriteLine("\n1.- Cuenta ahorro \n2.- Pensiones \n3.- Cuenta corriente");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bienvenido a Cuenta ahorro");
                    GetDataahorro();
                    break;
                case "2":
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDatapension();
                    break;
                case "3":
                    Console.WriteLine("Bienvenido a Cuenta corriente");
                    GetDatacorriente();
                    break;
            }


        }

        public int GetData()
        {
            //Se ingresa el numero de cuenta en string y se convierte a tipo int
            Console.WriteLine("Ingrese su numero de cuenta: ");
            string res = Console.ReadLine();
            return Convert.ToInt32(res);
        }

        public void GetDatapension()
        {
            //Se le asigna a una variable lo que se haga en el metodo Getdata() (el ingreso del numero de cuenta convertido a int) , 
            //se le asigna a otra variable lo que se haga en el metodo de lista de la clase pensiones donde se asignaron los valores de los atributos 
            //
            int number = GetData();
            var lista = dc.ListaP();
            Pensiones p = new Pensiones();
            

            foreach (var cuenta in lista)
            {
                if (number==cuenta.Numero)
                {
                    p = cuenta;
                }

            }
            Console.WriteLine("Bienvenido "+ p.Titular);
            Console.ReadKey();

            MenuUsuario(p);
        }

        public void MenuUsuario(Cuenta p)
        {
            
            Console.Clear();
            Console.WriteLine("1.-Consultar saldo \n2.-Transferir \n3.-Interes por mes \n 4.-Ingreso");

            switch (Console.ReadLine())
            {
                case "1":
                    cuenta.ConsultarSaldo(p);
                    break;

                case "2":
                    
                    break;

                case "3":

                    Console.WriteLine("Su interes por mes es: "+cuenta.Interesxmes(p));
                    
                    
                    break;

                case "4":
                    Console.WriteLine("Ingrese la cuenta que desea retirar dinero: ");

                    Console.WriteLine("Ingrese la cuenta a la que desea ingresar dinero: ");
                    break;
            }





        }

        public void GetDataahorro()
        {
            int number = GetData();
            var lista = dc.ListaCA();
            Cuentaahorro cuentaahorro = new Cuentaahorro();
            foreach (var cuenta in lista)
            {
                if (number == cuenta.Numero)
                {
                    cuentaahorro= cuenta;
                }

            }
            Console.WriteLine("Bienvenido " + cuentaahorro.Titular);
            Console.ReadKey();

            MenuUsuario(cuentaahorro);
        }
        public void GetDatacorriente()
        {
            int number = GetData();
            var lista = dc.ListaCC();
            Cuentacorriente cc = new Cuentacorriente();

            foreach (var cuenta in lista)
            {
                if (number==cuenta.Numero)
                {
                    cc = cuenta;
                }

                Console.WriteLine("Bienvenido " + cc.Titular);
                Console.ReadKey();

                MenuUsuario(cc);
            }
           
        }
    }
}
