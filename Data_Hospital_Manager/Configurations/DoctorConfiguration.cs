using Data_Hospital_Manager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Hospital_Manager.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(d => d.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(d => d.LastName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(d => d.Specialty)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(d => d.Email)
                .IsRequired();

            builder.Property(d => d.PhoneNumber)
                .IsRequired();

            builder.HasOne(d=>d.Hospital)
                .WithMany(h => h.Doctors)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Doctor
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Specialty = "Cardiology",
                    Email = "john.doe@example.com",
                    PhoneNumber = "0983211345",
                    HospitalId = 1
                },
                new Doctor
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Specialty = "Neurology",
                    Email = "jane.smith@example.com",
                    PhoneNumber = "0983211346",
                    HospitalId = 2
                }
            );
        }
    }
}
