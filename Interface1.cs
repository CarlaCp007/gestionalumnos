using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public interface IAlumno
    {
        string DNI { get; set; }
        string Apellidos { get; set; }
        string Nombre { get; set; }
        double Nota { get; set; }
        string Calificacion { get; }
    }
}
