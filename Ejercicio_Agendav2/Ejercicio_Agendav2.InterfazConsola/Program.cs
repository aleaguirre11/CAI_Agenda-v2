using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Agendav2.Entidades;
using Ejercicio_Agendav2.Entidades.Exceptions;

namespace Ejercicio_Agendav2.InterfazConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactoBase c1 = new ContactoEmpresa("Hardware Doc", DateTime.Now.AddYears(-25), 1, "Ignacio Canal 869");
            ContactoBase c2 = new ContactoPersona("Suyai", "Gonzales", DateTime.Now.AddYears(-20), 2,"Av Cabildo");
            ContactoBase c3 = new ContactoPersona("Ariel", "Perez", DateTime.Now.AddYears(-5), 3, "Av Santa Fe");

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
            Console.WriteLine("\n" + "1- Mostrar lista de contactos. " + "\n" + "2- Agregar contacto. " + "\n" + "3- Eliminar contacto. " + "\n" + "4- Llamar" + "\n");
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

            Console.WriteLine("Ingrese un codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese una direccion: ");
            string direccion = Console.ReadLine();

            Console.WriteLine("1 - Agregar contacto como empresa. " + "\n" + "2 - Agregar contacto como persona. ");

            string opcionMenu = Console.ReadLine();

            switch (opcionMenu)
            {
                case "1":
                    Console.WriteLine("Ingrese una razon social: ");
                    string razonsocial = Console.ReadLine();

                    Console.WriteLine("Ingrese la fecha de constitucion: ");
                    DateTime fechaconstitucion = DateTime.Parse(Console.ReadLine());

                    ContactoEmpresa c = new ContactoEmpresa(razonsocial, fechaconstitucion, codigo, direccion);
                    agendaElectronica.AgregarContacto(c);
                    break;

                case "2":
                    Console.WriteLine("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese el apellido: ");
                    string apellido = Console.ReadLine();

                    Console.WriteLine("Ingrese la fecha de nacimiento: ");
                    DateTime fechanacimiento = DateTime.Parse(Console.ReadLine());

                    ContactoBase contacto = new ContactoPersona(nombre, apellido, fechanacimiento, codigo, direccion);
                    agendaElectronica.AgregarContacto(contacto);
                    break;

                default:
                    break;
            }

        }

        public static void eliminarContacto(Agenda agendaElectronica)
        {
            try
            {
                Console.WriteLine("Ingrese el telefono del contacto a eliminar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                agendaElectronica.EliminarContacto(codigo);
            }
            catch (EliminarContactoException eliminarcontactoex)
            {
                Console.WriteLine(eliminarcontactoex.Message);
            }
        }

        public static void Llamar(Agenda agendaElectronica)
        {
            try
            {
                Console.WriteLine("Ingrese el codigo del contacto a llamar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                agendaElectronica.LlamarContacto(codigo);
            }
            catch (ContactoNoAtiendeException contactonoatiendeex)
            {
                Console.WriteLine(contactonoatiendeex.Message);
            }
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
