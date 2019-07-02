using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class Manejador
    {
        public Doctor Obtener(string nombre)
        {
            using (var contexto = new Contexto())
            {
                return contexto.Doctores.Where(doctor => doctor.Nombre == nombre).SingleOrDefault();                                        
            }
        }
        public void Crear(Doctor unDoctor)
        {
            using (Contexto contexto = new Contexto())
            {
                Doctor aObtener = Obtener(unDoctor.Nombre);
               if(aObtener != null)
                {
                    contexto.Doctores.Add(unDoctor);
                    contexto.SaveChanges();
                }
            }
        }
        public void Borrar(Doctor unDoctor)
        {
            using (Contexto contexto = new Contexto())
            {
                contexto.Entry(unDoctor).State = EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
        public void Actualizar(Doctor unDoctor)
        {
            using (Contexto contexto = new Contexto())
            {
                var doctorObt = contexto.Doctores.Where(doctor => doctor.Id == unDoctor.Id)
                                                         .SingleOrDefault();

                doctorObt.Nombre = unDoctor.Nombre;
                doctorObt.Especialidad = unDoctor.Especialidad;
                doctorObt.FechaDeNacimiento = unDoctor.FechaDeNacimiento;
                doctorObt.Hospitales = unDoctor.Hospitales;
                contexto.SaveChanges();
            }
        }

    }
}
