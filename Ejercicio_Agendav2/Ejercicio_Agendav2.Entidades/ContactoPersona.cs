using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades
{
    public class ContactoPersona : ContactoBase
    {
        public ContactoPersona(string nombre, string apellido, DateTime fechanacimiento, int codigo, string direccion) : base(codigo, direccion) //Base: palabra reservada
                                                                                                                   //para llamar al constructor del padre
        {
            _nombre = nombre;
            _apellido = apellido;
            _fechanacimiento = fechanacimiento;
        }

        private string _nombre;
        private string _apellido;
        private DateTime _fechanacimiento;

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

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set 
            { 
                _apellido = value; 
            }
        }

        public DateTime Fechanacimiento
        {
            get
            {
                return _fechanacimiento;
            }
            set
            {
                _fechanacimiento = value;
            }
        }
        public int Edad()
        {
            int edad = (DateTime.Now - _fechanacimiento).Days / 365;
            return Convert.ToInt32(edad);
        }
    }
}
