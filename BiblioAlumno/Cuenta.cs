using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioAlumno
{
    public class Cuenta
    {
        private static int Contador { get; set; } = 0;

        public int Cbu { get; set; } = 0;

        public double Saldo { get; set; } = 0;

        public Cuenta()



        {
             Contador ++;

             Cbu = 0;

             Saldo = 0;
        }

        public double Acreditar(double monto) => monto = monto +1 ;

        public double Debitar(double monto) => Saldo = Saldo - monto;

        public bool TieneAlemenos(double monto) => Saldo >= monto;
    }
            

    
    
}

