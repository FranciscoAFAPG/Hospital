using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_bases.Logica
{
    public class Empleado
    {
        private int identificacion;
        private string nombre;
        private string direccion;
        private string telefono;
        private string municipio;
        private string id_cargo;
        
        public Empleado()
        {
        }

        public Empleado(int Identificacion, string Nombre, string Direccion, string Telefono, string Municipio, string Id_cargo)
        {
            this.Identificacion = Identificacion;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Municipio = Municipio;
            this.Id_cargo = Id_cargo;
        }
      
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Id_cargo { get => id_cargo; set => id_cargo = value; }
    }
}
