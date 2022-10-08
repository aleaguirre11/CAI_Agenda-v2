using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.InterfazConsola.Excepciones
{
    public class ContactoNoAtiendeException : Exception
    {
        public ContactoNoAtiendeException(string mensaje) : base(mensaje)
        {

        }
        public ContactoNoAtiendeException() : base("El contacto no atiende.")
        {

        }
    }
}
