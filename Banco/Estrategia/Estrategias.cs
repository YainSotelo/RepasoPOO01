using System.Collections.Generic;
using System.Linq;
using Banco;
using Banco.Estrategia;

namespace Banco.Estrategias
{
    public static class Estrategias
    {
        static List<IEstrategia> Estra = new List<IEstrategia>()
        {
            new Ahorro(),

            new cauto(),

            new Emergencia(),
        };

        public static IEstrategia EstrategiaPara(Cliente cliente)
        
        => (Estra.FirstOrDefault(e => e.EsApto(cliente)));
        
    }
}




