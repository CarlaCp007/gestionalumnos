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
            btnAgregar, btnEliminar, btnConsultar, btnModificar, btnSuspensos, btnAprobados, btnMH, btnTodos, lstResultados });
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
            MessageBox.Show(alumno != null ? $"{alumno.DNI} - {alumno.Nombre} - {alumno.Nota}" : "No encontrado.");

        }







    }
}