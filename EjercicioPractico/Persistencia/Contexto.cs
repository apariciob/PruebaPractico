using Entidades;
using System;
using System.Data.Entity;

namespace Persistencia
{
    public class Contexto : DbContext
    {
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Doctor> Doctores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfiguracionDoctor());
            modelBuilder.Configurations.Add(new ConfiguracionHospital());
            modelBuilder.Entity<Doctor>()
                        .HasMany<Hospital>(doctor => doctor.Hospitales)
                        .WithMany(hospital => hospital.Doctores)
                        .Map(doctorHospital =>
                        {
                            doctorHospital.MapLeftKey("doctorId");
                            doctorHospital.MapRightKey("HospitalId");
                            doctorHospital.ToTable("DoctorHospital");
                        });

        }
    }
}
