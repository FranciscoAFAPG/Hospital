using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases.Logica
{
    class Diagnostico
    {
        private int id_diagnostico;
        private string observaciones;
        private int id_enfermedad;
        private int id_paciente;

        public Diagnostico()
        {
        }

        public Diagnostico(int Id_diagnostico, string Observaciones, int Id_enfermedad, int Id_paciente)
        {
            this.id_diagnostico = Id_diagnostico;
            this.observaciones = Observaciones;
            this.id_enfermedad = Id_enfermedad;
            this.id_paciente = Id_paciente;
        }

        public int Id_diagnostico { get => id_diagnostico; set => id_diagnostico = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int Id_enfermedad { get => id_enfermedad; set => id_enfermedad = value; }
        public int Id_paciente { get => id_paciente; set => id_paciente = value; }
    }
}
