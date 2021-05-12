using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioAlumno
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Club { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }



        public double Imc()
        {
            return Peso / Altura * Altura;
        }

        
        public double IMC => Peso / (Altura * Altura);
        public string DescripcionIMC
        {
            get
            {
                switch (IMC)
                {
                    case double v when v < 18.5: return "Bajo";
                    case double v when v >= 18.5 && v < 25: return "Normal";
                    case double v when v >= 25 && v < 30: return "Warning";
                    default: return "Warning";
                }
            }
        }
        public bool SosDe(string unEquipo) => Club == unEquipo;
    }
}






