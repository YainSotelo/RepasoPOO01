using System;

namespace BiblioAlumno
{
    public class Alumno
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
        public void NombreEs(string UnNombre)
        {
            this.nombre = UnNombre;
        }
        public void SetDni(int dni)
        {
            this.dni = dni;
        }
            public int GetDni()
        {
            return this.dni;
        }

    }
}
    
