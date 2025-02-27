using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class FormGestionCalificaciones : Form
    {
        public FormGestionCalificaciones()
        {

            InitializeComponent();
            this.Controls.AddRange(new Control[] { lblNombre, txtDni, lblApellidos, txtApellidos, lblNombre, txtNombre, lblNota, txtNota,
            btnAgregar, btnEliminar, btnConsultar, btnModificar, btnSuspensos, btnAprobados, btnMH, btnTodos,lstResultados});
        }

        private GestionCalificaciones GestionCalificaciones = new GestionCalificaciones();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                var alumno = new Alumno(txtDni.Text, txtApellidos.Text, txtNombre.Text, double.Parse(txtNota.Text));
                GestionCalificaciones.IntroducirAlumno(alumno);
                MessageBox.Show("Alumno agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GestionCalificaciones.EliminarAlumno(txtDni.Text))
                MessageBox.Show("Alumno eliminado.");
            else
                MessageBox.Show("No encontrado.");

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var alumno = GestionCalificaciones.ConsultarAlumno(txtDni.Text);
            MessageBox.Show(alumno != null ? $"{alumno.DNI} - {alumno.Apellidos} - {alumno.Nombre} - {alumno.Nota} - {alumno.Calificacion}" : "No encontrado.");

        }

        private void btnSuspensos_Click(object sender, EventArgs e)
        {
            // Obtener la lista de alumnos suspensos
            List<Alumno> suspensos = GestionCalificaciones.ObtenerSuspensos();

            // Mostrar los resultados en la ListBox o en un MessageBox
            if (suspensos.Count > 0)
            {
                lstResultados.Items.Clear(); // Limpiar lista antes de agregar nuevos datos

                foreach (var alumno in suspensos)
                {
                    lstResultados.Items.Add($"{alumno.DNI} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}- Calificacion: {alumno.Calificacion}");
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos suspensos.");
            }
        }

        private void btnAprobados_Click(object sender, EventArgs e)
        {
            List<Alumno> aprobados = GestionCalificaciones.ObtenerAprobados();

            // Mostrar los resultados en la ListBox o en un MessageBox
            if (aprobados.Count > 0)
            {
                lstResultados.Items.Clear(); // Limpiar lista antes de agregar nuevos datos

                foreach (var alumno in aprobados)
                {
                    lstResultados.Items.Add($"{alumno.DNI} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}- Calificacion: {alumno.Calificacion}");
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos aprobados.");
            }
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            List<Alumno> mh = GestionCalificaciones.ObtenerMH();

            // Mostrar los resultados en la ListBox o en un MessageBox
            if (mh.Count > 0)
            {
                lstResultados.Items.Clear(); // Limpiar lista antes de agregar nuevos datos

                foreach (var alumno in mh)
                {
                    lstResultados.Items.Add($"{alumno.DNI} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}- Calificacion: {alumno.Calificacion}");
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos MH.");
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            List<Alumno> todos = GestionCalificaciones.ObtenerTodos();

            // Mostrar los resultados en la ListBox o en un MessageBox
            if (todos.Count > 0)
            {
                lstResultados.Items.Clear(); // Limpiar lista antes de agregar nuevos datos
                
                foreach (var alumno in todos)
                {
                    lstResultados.Items.Add($"{alumno.DNI} - {alumno.Nombre} {alumno.Apellidos} - Nota: {alumno.Nota}- Calificacion: {alumno.Calificacion}");
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos.");
            }
        }
    }
}