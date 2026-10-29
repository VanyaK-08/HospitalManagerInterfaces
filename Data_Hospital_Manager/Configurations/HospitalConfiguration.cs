using Data_Hospital_Manager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Hospital_Manager.Configurations
{
    public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasData(
                new Hospital
                {
                    Id = 1,
                    Name = "МБАЛ Казанлък",
                    Address = "Казанлък",
                    Email = "hospital@example.com",
                    PhoneNumber = "0888123456",
                    BedsCount = 200,
                    CreatedOn = new DateTime(2026, 1, 1),
                    IsDeleted = false,
                },
                new Hospital
                {
                    Id = 2,
                    Name = "УМБАЛ Стара Загора",
                    Address = "Стара Загора",
                    Email = "hospital2@example.com",
                    PhoneNumber = "0888654321",
                    BedsCount = 350,
                    CreatedOn = new DateTime(2026, 1, 1),
                    IsDeleted = false,
                }
            );
        }
    }
}
