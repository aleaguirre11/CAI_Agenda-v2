using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades
{
    public class Agenda
    {
        public Agenda(string nombre, string tipo, int cantidadMax)
        {
            _nombre = nombre;
            _tipo = tipo;
            _cantidadMax = cantidadMax;
            _contactos = new List<ContactoBase>();
        }

        private string _nombre;
        private string _tipo;
        private int _cantidadMax = 20;
        private List<ContactoBase> _contactos;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        public int CantidadMax
        {
            get
            {
                return _cantidadMax;
            }
            set
            {
                _cantidadMax= value;
            }
        }

        public List<ContactoBase> Contactos
        {
            get
            {
                return _contactos;
            }
        }

        public void AgregarContacto()
        {
            
        }

        public void EliminarContacto(int codigo)
        {

            foreach(ContactoBase contacto in Contactos)
            {
                if(contacto.Codigo == codigo)
                {
                    Contactos.Remove(contacto);
                }
            }
        }

        public void TraerContacto()
        {

        }
    }
}
