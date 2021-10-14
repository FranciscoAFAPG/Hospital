using System;
using System.Collections.Generic;
using System.Text;

namespace proyecto_bases.Logica
{
    public class Medico
    {
        private int lic_medica;
        private int id_tipo_medico;
        private int id_especialidad;
        private int id_identificacion;

        public Medico()
        {
        }
        public Medico(int Lic_medica, int Id_tipo_medico, int Id_especialidad, int Id_identificacion)
        {
            this.lic_medica = Lic_medica;
            this.id_tipo_medico = Id_tipo_medico;
            this.id_especialidad = Id_especialidad;
            this.id_identificacion = Id_identificacion;
        }
        public int Lic_medica
        {
            get => lic_medica;
            set => lic_medica = value;
        }
        public int Id_tipo_medico
        {
            get => id_tipo_medico;
            set => id_tipo_medico = value;
        }
        public int Id_especialidad
        {
            get => id_especialidad;
            set => id_especialidad = value;
        }
        public int Id_identificacion
        {
            get => id_identificacion;
            set => id_identificacion = value;
        }
    }
}
