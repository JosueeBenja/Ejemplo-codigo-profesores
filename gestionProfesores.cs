using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_codigo_profesores
{
    public partial class gestionProfesores : Form
    {
        public gestionProfesores()
        {
            InitializeComponent();
        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombre = campoNombre.Text.Trim();
            string apellido = campoApellido.Text.Trim();
            string especialidad = campoEspecialidad.Text.Trim();
            string telefono = campoTelefono.Text.Trim();
            string correo = campoCorreo.Text.Trim();
            string direccion = campoDireccion.Text.Trim();
            string fechaNacimiento = campoFechaNacimiento.Text.Trim();
            string numeroId = campoNumeroId.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(especialidad)
                || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(direccion) || string.IsNullOrEmpty(fechaNacimiento)
                || string.IsNullOrEmpty(numeroId))
            {
                MessageBox.Show("Todos los campos son requeridos");
                return;
            }

            Profesor nuevoProfesor = new Profesor(nombre, apellido, especialidad, telefono, correo, direccion, fechaNacimiento, numeroId);

            string csvPath = "../../../Registro de profesores.csv";
            using (StreamWriter writer = new StreamWriter(csvPath, true))
            {
                writer.WriteLine($"{nuevoProfesor.Nombre},{nuevoProfesor.Apellido},{nuevoProfesor.Especialidad},{nuevoProfesor.Telefono},{nuevoProfesor.CorreoElectronico},{nuevoProfesor.DireccionResidencia},{nuevoProfesor.FechaNacimiento},{nuevoProfesor.NumeroIdentificacion}");
            }

            LimpiarFormulario();

            MessageBox.Show("Profesor guardado exitosamente.");
        }
        private void LimpiarFormulario()
        {
            campoNombre.Clear();
            campoApellido.Clear();
            campoEspecialidad.Clear();
            campoTelefono.Clear();
            campoCorreo.Clear();
            campoDireccion.Clear();
            campoFechaNacimiento.Clear();
            campoNumeroId.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Opcion1 = new Form1();
            Opcion1.Show();
        }

        private void campoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void campoFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }
        private void campoNumeroIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }
        private void EditarActualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActualizarLista Opcion1 = new ActualizarLista();
            Opcion1.Show();
        }

        private void gestionProfesores_Load(object sender, EventArgs e)
        {

        }

        private void ListarProfesores_Click(object sender, EventArgs e)
        {

        }
    }
}
