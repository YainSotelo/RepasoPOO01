using System;
using System.Collections.Generic;
using System text;

namespace BiblioAlumno.Estrategia
{
   public class cauto : IEstrategia
   {
       public void Acreditar(Cliente cliente, double monto)
       {
           cliente.AcreditarEfectivo(monto * 0.8);

           cliente.cuenta.Acreditar(monto * 0.2);
           
       }
         public void Debitar(Cliente cliente , double monto)
         {
             cliente.DebitarEfectivo(monto * 0.8);

             cliente.cuenta.Debitar(monto * 0.2);
         }
         
         public bool EsApto(Cliente cliente) => cliente.Efectivo >=10000 && cliente.Efectivo <= 50000;

   } 
}