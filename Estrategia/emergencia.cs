using System;
using System.Collections.Generic;
using System.Text;
using BiblioAlumno;

namespace BiblioAlumno.Estrategia
{
    public class Emergencia : IEstrategia
    {
        public void Acreditar(Cliente cliente , double monto)
        {
            cliente.AcreditarEfectivo(monto);
        }
        public void Debitar(Cliente cliente , double monto)
        {
            if(cliente.cuenta.TieneAlemenos(monto))
            {
                cliente.cuenta.Debitar(monto);
            }
            else
            {
                monto -= cliente.cuenta.VaciarCuenta();

                cliente.DebitarEfectivo(monto);
            }
        }
        public bool EsApto(Cliente cliente) => cliente.Efectivo < 10000;
    }   
}