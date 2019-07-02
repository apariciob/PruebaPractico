using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            Manejador miManejador = new Manejador();
            miManejador.Crear(new Doctor
            {
                Nombre = "Jose Andrade",
                FechaDeNacimiento = new DateTime(1984, 11, 12),
                Especialidad = Especialidad.Fisiatria,
            });
        }
    }
}
