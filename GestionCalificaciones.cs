using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    public class GestionCalificaciones : IGestionCalificaciones
    {
        private Dictionary<string, Alumno> alumnos;

        public GestionCalificaciones()
        {
            alumnos = new Dictionary<string, Alumno>();
        }

        public void IntroducirAlumno(Alumno alumno)
        {
            if (!alumnos.ContainsKey(alumno.DNI))
            {
                alumnos.Add(alumno.DNI, alumno);
            }
            else
            {
                throw new Exception("El alumno con este DNI ya existe.");
            }
        }

        public bool EliminarAlumno(string dni)
        {
            return alumnos.Remove(dni);
        }

        public Alumno ConsultarAlumno(string dni)
        {
            return alumnos.ContainsKey(dni) ? alumnos[dni] : null;
        }

        public bool ModificarNota(string dni, double nuevaNota)
        {
            if (alumnos.ContainsKey(dni))
            {
                alumnos[dni].Nota = nuevaNota;
                return true;
            }
            return false;
        }

        public List<Alumno> ObtenerAprobados()
        {
            return new List<Alumno>(alumnos.Values).FindAll(a => a.Nota >= 5);
        }

        public List<Alumno> ObtenerSuspensos()
        {
            return new List<Alumno>(alumnos.Values).FindAll(a => a.Nota < 5);
        }

        public List<Alumno> ObtenerMH()
        {
            return new List<Alumno>(alumnos.Values).FindAll(a => a.Nota == 10);
        }


        public List<Alumno> ObtenerTodos()
        {
            return new List<Alumno>(alumnos.Values);
        }
    }

}
