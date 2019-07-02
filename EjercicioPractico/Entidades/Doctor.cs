using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public Especialidad Especialidad { get; set; }

        public List<Hospital> Hospitales { get; set; }
    }
}
