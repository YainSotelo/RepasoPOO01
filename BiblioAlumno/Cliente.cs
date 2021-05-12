using BiblioAlumno;
using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioAlumno
{
    class Cliente
    {
        public Cuenta Cuenta { get; set; }
        
        public string nombre { get; set; }
        public string apellido { get; set; }
        public double Efectivo { get; set; } = 0;

        public int Cbu { get; set; } = 0;



        public Cliente()
        {
            new Cuenta()
        }

        
    }
}
