using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades.Exceptions
{
    public class ContactoNoAtiendeException : Exception
    {
        public ContactoNoAtiendeException() : base("El contacto no atiende.")
        {

        }
    }
}
