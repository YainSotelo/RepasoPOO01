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

        public double Saldo { get; set; }

        public Cliente()
        {
            Cuenta cuenta = new Cuenta();
        }
        

        public void Acreditar(double monto)
        {
            Efectivo = Efectivo + monto;
            Cuenta.Acreditar(monto * 0.2);
        }

        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto;
            Cuenta.Debitar(monto / 0.2);
        }

        public bool TieneAlemenos(double monto) => Saldo >= monto;


    }
}
