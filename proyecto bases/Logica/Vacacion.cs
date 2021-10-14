using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases.Logica
{
    public class Vacacion
    {
        private int identificacion;
        private string nombre;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        public Vacacion()
        {
        }

        public Vacacion(int Identificacion, DateTime FechaInicio, DateTime FechaFin)
        {
            this.Identificacion = Identificacion;
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
        }
        public Vacacion(int Identificacion,string nombre, DateTime FechaInicio, DateTime FechaFin)
        {
            this.Identificacion = Identificacion;
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
            this.Nombre = nombre;
        }
        public int Identificacion { get => identificacion; set => identificacion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin  { get => fechaFin; set => fechaFin = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
