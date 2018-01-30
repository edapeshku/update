using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eSupport.Services.Equipment.Infrastructure;
using eSupport.Services.Equipment.Infrastructure.Idempotency;

namespace eSupport.Services.Equipment.Infrastructure.EntityConfiguration
{
    class ClientRequestEntityTypeConfiguration
        : IEntityTypeConfiguration<ClientRequest>
    {
        public void Configure(EntityTypeBuilder<ClientRequest> requestConfiguration)
        {
            requestConfiguration.ToTable("requests", EquipmentContext.DEFAULT_SCHEMA);
            requestConfiguration.HasKey(cr => cr.Id);
            requestConfiguration.Property(cr => cr.Name).IsRequired();
            requestConfiguration.Property(cr => cr.Time).IsRequired();
        }
    }
}