using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eSupport.Services.Equipment.Infrastructure;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentTypeAggregate;

namespace eSupport.Services.Equipment.Infrastructure.EntityConfiguration
{
    public class EquipmentTypeEntityTypeConfiguration
        : IEntityTypeConfiguration<EquipmentType>
    {
        public void Configure(EntityTypeBuilder<EquipmentType> orderConfiguration)
        {

        }
    }
}