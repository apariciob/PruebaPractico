using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public List<Doctor> Doctores { get; set; }
    }
}
