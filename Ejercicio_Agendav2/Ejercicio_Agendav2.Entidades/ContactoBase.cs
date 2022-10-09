using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Agendav2.Entidades.Exceptions;

namespace Ejercicio_Agendav2.Entidades
{
    public abstract class ContactoBase //Con abstract class no permitimos instanciar ContactoBase, solo heredarla, ya que no tiene sentido crear un Contaco Base
                                       //Si nos permite utilizarlo como variable

    {
        public ContactoBase(int codigo, string direccion)
        {
            _codigo = codigo;
            _direccion = direccion;
            _llamadas = 0;
        }
        //Usamos protected para que los hijos puedan acceder a las propiedades
        //si usaramos internal, solo pueden acceder las clases que esten dentro del proyecto
        //por ejemplo el program no tendria acceso porque esta por fuera de este proyecto
        protected int _codigo;      
        protected string _direccion;   
        protected int _llamadas;

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public int Llamadas
        {
            get
            {
                return _llamadas;
            }
            set
            {
                _llamadas = value;
            }
        }

        public void Llamar()
        {
            _llamadas++;    

            if(_llamadas == 1)
            {
                throw new ContactoNoAtiendeException();
            }
        }
    }
}
