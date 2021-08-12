
namespace BiblioAlumno
{
    public interface IEstrategia
    {
        void Debitar (Cliente cliente,double monto);

        void Acreditar(Cliente cliente,double monto);

        void EsApto(Cliente cliente);
    }
}