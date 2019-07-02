using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Persistencia
{
    public class ConfiguracionHospital : EntityTypeConfiguration<Hospital>
    {
        public ConfiguracionHospital()
        {
            ToTable("Hospitales");
            Property(hospital => hospital.Nombre).IsRequired();
        }
    }
}
