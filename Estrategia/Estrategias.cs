using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.BiblioAlumno;

namespace BiblioAlumno.Estrategias
{
    public static class Estrategias
    {
        static List< IEstrategia> Estra = new List<IEstrategia>()
        {
            new Ahorro(),

            new cauto(),

            new Emergencia(),
        };

        public static IEstrategia EstrategiaPara(Cliente cliente)
        {
            return (Estra.FirstOrDefault(e => e.EsApto(cliente)));
        }
    }
}

   


