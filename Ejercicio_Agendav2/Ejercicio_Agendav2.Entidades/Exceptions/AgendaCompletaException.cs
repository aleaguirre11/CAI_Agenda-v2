using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades.Exceptions
{
    public class AgendaCompletaException : Exception
    {
        public AgendaCompletaException() : base("La agenda se encuentra completa.")
        {

        }
    }
}
