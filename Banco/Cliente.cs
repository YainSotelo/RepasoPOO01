using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Banco.Estrategia;

namespace Banco
{
    public class Cliente 
    {
        public IEstrategia Estrategia;

        internal void AcreditarEfectivo(double monto)
            => Efectivo = Efectivo + monto;   

        public Cuenta cuenta { get; set; }
        
        public string nombre { get; set; }

        internal void DebitarEfectivo(double monto)
            => Efectivo = Efectivo - monto;

        public string apellido { get; set; }

        public double Efectivo { get; set; } = 0;

        internal double VaciarEfectivo()
        {
            var Efectivo = this.Efectivo;
            Efectivo=0;
            return Efectivo;
        }

        public int Cbu { get; set; } = 0;

        public double Saldo { get; set; }

        public Cliente()
        {
            Cuenta cuenta = new Cuenta();
        }

        public void Acreditar(double monto)
        {
            Efectivo = Efectivo + monto;
            cuenta.Acreditar(monto * 0.2);
        }

        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto;
            cuenta.Debitar(monto / 0.2);
        }

        public bool TieneAlemenos(double monto) => Saldo >= monto;


    }
}
