using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Agendav2.Entidades;

namespace Ejercicio_Agendav2.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactoBase c1 = new ContactoEmpresa("Hardware Doc", 0, 1, "Ignacio Canal 869");
            ContactoBase c2 = new ContactoPersona("Suyai", "Gonzales", 2233, 2 ,"Av Cabildo");
            ContactoBase c3 = new ContactoPersona("Ariel", "Perez", 1234, 3, "Av Santa Fe");

            try
            {
                Agenda agendaElectronica = new Agenda("Mi Agenda", "Electronica", 20);
                agendaElectronica.AgregarContacto(c1);
                agendaElectronica.AgregarContacto(c2);
                agendaElectronica.AgregarContacto(c3);

                bool consolaActiva = true;

                while (consolaActiva)
                {
                    DesplegarOpcionesMenu();
                    string opcionMenu = Console.ReadLine();

                    switch (opcionMenu)
                    {
                        case "1":
                            Listar(agendaElectronica);
                            break;

                        case "2":
                            Agregar(agendaElectronica);
                            break;

                        case "3":
                            eliminarContacto(agendaElectronica);
                            break;
                        case "4":
                            Llamar(agendaElectronica);
                            break;
                        case "x":
                            consolaActiva = false;
                            break;

                        default:
                            break;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general");
            }
        }

        public static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1- Mostrar lista de contactos. " + "\n" + "2- Agregar contacto. " + "\n" + "3- Eliminar contacto. " + "\n" + "4- Llamar");
        }

        public static void Listar(Agenda agendaElectronica)
        {
            foreach (ContactoBase c in agendaElectronica.Contactos)
            {
                Console.WriteLine(c.Codigo + " - " + c.Direccion + " - " + c.Llamadas);
            }
        }

        public static void Agregar(Agenda agendaElectronica)
        {
            Console.WriteLine("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese un apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese un telefono: ");
            string telefono = Console.ReadLine();

            Console.WriteLine("Ingrese una direccion: ");
            string direccion = Console.ReadLine();

            Console.WriteLine("Ingrese la edad: ");
            int edad = Convert.ToByte(Console.ReadLine());


            Contacto c = new Contacto(nombre, apellido, telefono, direccion, edad);
            agendaElectronica.AgregarContacto(c);
        }

        public static void eliminarContacto(Agenda agendaElectronica)
        {
            Console.WriteLine("Ingrese el telefono del contacto a eliminar: ");
            string telefono = Console.ReadLine();

            agendaElectronica.EliminarContacto(telefono);
        }

        public static void Llamar(Agenda agendaElectronica)
        {
            Console.WriteLine("Ingrese el nombre del contacto a llamar: ");
            string nombre = Console.ReadLine();

            agendaElectronica.LlamarContacto(nombre);
        }

        private static void MostrarNombre(ContactoBase contacto)
        {
            if(contacto is ContactoEmpresa)
            {
                ContactoEmpresa contactoEmpresa = (ContactoEmpresa)contacto;
                Console.WriteLine(contactoEmpresa.Razonsocial);
            }
            else if(contacto is ContactoPersona)
            {
                ContactoPersona contactopersona = (ContactoPersona)contacto;
                Console.WriteLine(contactopersona.Nombre);
            }
        }
       
    }
}
