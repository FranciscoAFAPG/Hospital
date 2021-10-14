using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases.Logica
{
    public class Sustituciones
    {
        
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string nombre;
        private int licencia;
        public Sustituciones()
        {

        }
        public Sustituciones(DateTime FechaInicio, DateTime FechaFin)
        {
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
        }

        public Sustituciones(string Nombre, DateTime FechaInicio, DateTime FechaFin)
        {
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
            this.Nombre = Nombre;
        }
        public Sustituciones(int licencia, DateTime FechaInicio, DateTime FechaFin)
        {
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
            this.Licencia = licencia;
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public int Licencia { get => licencia; set => licencia = value; }

    }
}
