using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades.Exceptions
{
    public class EliminarContactoException : Exception
    {
        public EliminarContactoException() : base("No se pudo eliminar el contacto.")
        {

        }
    }
}
