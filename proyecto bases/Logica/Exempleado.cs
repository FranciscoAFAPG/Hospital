using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases.Logica
{
    public class Exempleado
    {
        private int identificacion;
        private string nombre;
        private string direccion;
        private int telefono;
        private string municipio;
        private string cargo;

        public Exempleado()
        {
        }

        public Exempleado(int Identificacion, string Nombre, string Direccion, int Telefono, string Municipio, string cargo)
        {
            this.Identificacion = Identificacion;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Municipio = Municipio;
            this.Cargo = cargo;
        }

        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
