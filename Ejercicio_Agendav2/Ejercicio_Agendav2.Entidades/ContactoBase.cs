using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades
{
    public class ContactoBase
    {
        public ContactoBase(int codigo, string direccion)
        {
            _codigo = codigo;
            _direccion = direccion;
            _llamadas = 0;
        }

        private int _codigo;      
        private string _direccion;   
        private int _llamadas;

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
        }
    }
}
