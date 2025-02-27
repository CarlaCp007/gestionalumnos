using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public interface IGestionCalificaciones
    {
        void IntroducirAlumno(Alumno alumno);
        bool EliminarAlumno(string dni);
        Alumno ConsultarAlumno(string dni);
        bool ModificarNota(string dni, double nuevaNota);
        List<Alumno> ObtenerAprobados();
        List<Alumno> ObtenerSuspensos();
        List<Alumno> ObtenerMH();
        List<Alumno> ObtenerTodos();
    }
}
