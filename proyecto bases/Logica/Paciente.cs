using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases.Logica
{
    class Paciente
    {
        private int identificacion;
        private string nombre;
        private string direccion;
        private string telefono;
        private string municipio;

        public Paciente()
        {
        }

        public Paciente(int Identificacion, string Nombre, string Direccion, string Telefono, string Municipio)
        {
            this.identificacion = Identificacion;
            this.nombre = Nombre;
            this.direccion = Direccion;
            this.telefono = Telefono;
            this.municipio = Municipio;
        }

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Municipio { get => municipio; set => municipio = value; }
    }
}
