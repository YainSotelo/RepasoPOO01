using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioAlumno
{
    class Alumno2
    {
        string Club;
        string nombre;
        string apellido;
        DateTime nacimiento;
        int dni;

        public string Saludar()
        {
            return $"hola soy {this.nombre}";
        }
        public bool SosDe(string UnClub)
        {
            return UnClub == this.Club;
        }
        public string Nombre
        {
            set { this.nombre = value; }
        }
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }


    }
        
      

}
    

