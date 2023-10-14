using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_codigo_profesores
{
    internal class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string DireccionResidencia { get; set; }
        public string FechaNacimiento { get; set; }
        public string NumeroIdentificacion { get; set; }

        public Profesor(string nombre, string apellido, string especialidad, string telefono, string correo, string direccion, string fechaNacimiento, string numeroId)
        {
            Nombre = nombre;
            Apellido = apellido;
            Especialidad = especialidad;
            Telefono = telefono;
            CorreoElectronico = correo;
            DireccionResidencia = direccion;
            FechaNacimiento = fechaNacimiento;
            NumeroIdentificacion = numeroId;
        }
    }
}
