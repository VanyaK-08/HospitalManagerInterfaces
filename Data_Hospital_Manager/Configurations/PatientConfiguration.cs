using Data_Hospital_Manager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Hospital_Manager.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(p => p.Email)
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .IsRequired();

            builder.HasData(
                new Patient
                {
                    Id = 1,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Email = "alice.johnson@example.com",
                    PhoneNumber = "0896754321"
                },
                new Patient
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Smith",
                    Email = "bob.smith@example.com",
                    PhoneNumber = "0891234567"
                },
                new Patient
                {
                    Id = 3,
                    FirstName = "Charlie",
                    LastName = "Brown",
                    Email = "charlie.brown@example.com",
                    PhoneNumber = "0899876543"
                }
            );
        }
    }
}
