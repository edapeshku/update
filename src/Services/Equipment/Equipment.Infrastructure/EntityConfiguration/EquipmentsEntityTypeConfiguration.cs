using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eSupport.Services.Equipment.Infrastructure;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate;

namespace eSupport.Services.Equipment.Infrastructure.EntityConfiguration
{
    public class EquipmentsEntityTypeConfiguration
        : IEntityTypeConfiguration<Equipments>
    {
        public void Configure(EntityTypeBuilder<Equipments> orderConfiguration)
        { 

        }
    }
}