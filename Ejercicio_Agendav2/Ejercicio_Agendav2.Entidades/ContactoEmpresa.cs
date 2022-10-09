using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Agendav2.Entidades
{
    public class ContactoEmpresa : ContactoBase
    {
        public ContactoEmpresa(string razonsocial, DateTime fechaconstitucion, int codigo, string direccion) : base(codigo, direccion)
        {
            _razonsocial = razonsocial;
            _fechaconstitucion = fechaconstitucion;
        }

        private string _razonsocial;
        private DateTime _fechaconstitucion;


        public string Razonsocial
        {
            get
            {
                return _razonsocial;
            }
            set
            {
                _razonsocial = value;
            }
        }

        public DateTime Fechaconstitucion
        {
            get
            {
                return _fechaconstitucion;
            }
            set
            {
                _fechaconstitucion= value;
            }
        }

        public int Antiguedad()
        {
            int antiguedad = (DateTime.Now - _fechaconstitucion).Days/365;
            return Convert.ToInt32(antiguedad);     
        }

           
    }
}
