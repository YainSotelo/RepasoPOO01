using Banco;

namespace Banco.Estrategia
{
    public class Ahorro : IEstrategia
    {
        public void Acreditar(Cliente cliente , double monto)
        {
            cliente.AcreditarEfectivo(monto * 0.5);

            cliente.Cuenta.Acreditar(monto * 0.5);
        }
        public void Debitar(Cliente cliente,double monto)
        {
            if(cliente.TieneAlemenos(monto))
            {
                cliente.DebitarEfectivo(monto);
            }
            else
            {
                monto -= cliente.VaciarCuenta();

                cliente.cuenta.Debitar(monto);
            }
        }
        public bool EsApto(Cliente cliente) => cliente.Efectivo > 50000;
    }
}