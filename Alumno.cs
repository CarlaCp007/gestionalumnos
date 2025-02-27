using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class Alumno : IAlumno
    {
        public string DNI { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public double Nota { get; set; }

        public string Calificacion
        {
            get
            {
                if (Nota < 5) return "SS";
                if (Nota < 7) return "AP";
                if (Nota < 9) return "NT";
                return "SB";
            }
        }

        public Alumno(string dni, string apellidos, string nombre, double nota)
        {
            DNI = dni;
            Apellidos = apellidos;
            Nombre = nombre;
            Nota = nota;
        }
    }

}
