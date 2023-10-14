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
    public partial class ActualizarLista : Form
    {
        private List<Profesor> listaProfesores;
        private string csvPath = "../../../Registro de profesores.csv";
        public ActualizarLista()
        {
            InitializeComponent();
            listaProfesores = new List<Profesor>();
            CargarProfesoresDesdeCSV();
            ActualizarDataGridView();
        }
        private void CargarProfesoresDesdeCSV()
        {
            if (File.Exists(csvPath))
            {
                listaProfesores.Clear();
                using (StreamReader reader = new StreamReader(csvPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 8)
                        {
                            Profesor profesor = new Profesor(
                                parts[0], parts[1], parts[2], parts[3], parts[4],
                                parts[5], parts[6], parts[7]);
                            listaProfesores.Add(profesor);
                        }
                    }
                }
            }
        }

        private void ActualizarDataGridView()
        {
            dataGridViewProfesores.Rows.Clear();
            foreach (var profesor in listaProfesores)
            {
                dataGridViewProfesores.Rows.Add(profesor.Nombre, profesor.Apellido, profesor.Especialidad, profesor.Telefono, profesor.CorreoElectronico, profesor.DireccionResidencia, profesor.FechaNacimiento, profesor.NumeroIdentificacion);
            }
        }

        private void ActualizarLista_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProfesores.Rows[e.RowIndex];
                int selectedIndex = e.RowIndex;
                if (selectedIndex >= 0 && selectedIndex < listaProfesores.Count)
                {
                    Profesor profesor = listaProfesores[selectedIndex];
                    campoNombre.Text = profesor.Nombre;
                    campoApellido.Text = profesor.Apellido;
                    campoEspecialidad.Text = profesor.Especialidad;
                    campoTelefono.Text = profesor.Telefono;
                    campoCorreo.Text = profesor.CorreoElectronico;
                    campoDireccion.Text = profesor.DireccionResidencia;
                    campoFechaNacimiento.Text = profesor.FechaNacimiento;
                    campoNumeroId.Text = profesor.NumeroIdentificacion;
                }
            }
        }


        private void dataGridViewProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void campoIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionProfesores Opcion1 = new gestionProfesores();
            Opcion1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridViewProfesores.SelectedCells[0].RowIndex;
            if (selectedIndex >= 0 && selectedIndex < listaProfesores.Count)
            {

                listaProfesores[selectedIndex] = new Profesor(
                    campoNombre.Text, campoApellido.Text, campoEspecialidad.Text,
                    campoTelefono.Text, campoCorreo.Text, campoDireccion.Text,
                    campoFechaNacimiento.Text, campoNumeroId.Text);

                dataGridViewProfesores.Rows[selectedIndex].SetValues(
                    campoNombre.Text, campoApellido.Text, campoEspecialidad.Text,
                    campoTelefono.Text, campoCorreo.Text, campoDireccion.Text,
                    campoFechaNacimiento.Text, campoNumeroId.Text);

                GuardarProfesoresEnCSV();
            }
        }
        private void GuardarProfesoresEnCSV()
        {
            using (StreamWriter writer = new StreamWriter(csvPath, false))
            {
                foreach (var profesor in listaProfesores)
                {
                    writer.WriteLine($"{profesor.Nombre},{profesor.Apellido},{profesor.Especialidad},{profesor.Telefono},{profesor.CorreoElectronico},{profesor.DireccionResidencia},{profesor.FechaNacimiento},{profesor.NumeroIdentificacion}");
                }
            }
        }

        private void ListarProfesores_Click(object sender, EventArgs e)
        {
            CargarProfesoresDesdeCSV();
            ActualizarDataGridView();
        }
    }
}
