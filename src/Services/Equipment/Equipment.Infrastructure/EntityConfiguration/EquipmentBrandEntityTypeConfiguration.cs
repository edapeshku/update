using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eSupport.Services.Equipment.Infrastructure;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentBrandAggregate;

namespace eSupport.Services.Equipment.Infrastructure.EntityConfiguration
{
    public class EquipmentBrandEntityTypeConfiguration
        : IEntityTypeConfiguration<EquipmentBrand>
    {
        public void Configure(EntityTypeBuilder<EquipmentBrand> orderConfiguration)
        {

        }
    }
}