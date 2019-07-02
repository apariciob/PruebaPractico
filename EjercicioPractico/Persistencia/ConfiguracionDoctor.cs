using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Persistencia
{
    public class ConfiguracionDoctor : EntityTypeConfiguration<Doctor>
    {
        public ConfiguracionDoctor()
        {
            ToTable("Doctores");
            Property(doctor => doctor.Nombre).IsRequired();            
        }
    }
}
