using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentBrandAggregate;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentTypeAggregate;
using eSupport.Services.Equipment.Domain.SeedWork;
using eSupport.Services.Equipment.Infrastructure.EntityConfiguration;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace eSupport.Services.Equipment.Infrastructure
{
    public class EquipmentContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "equipment";
        public DbSet<Equipments> Equipments { get; set; }

        public DbSet<EquipmentBrand> EquipmentBrand { get; set; }
        
        public DbSet<EquipmentType> EquipmentType { get; set; }

        public DbSet<EquipmentStatus> EquipmentStatus { get; set; }

        private readonly IMediator _mediator;

        private EquipmentContext(DbContextOptions<EquipmentContext> options) : base(options) { }

        private EquipmentContext(DbContextOptions<EquipmentContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

            System.Diagnostics.Debug.WriteLine("EquipmentContext::ctor ->" + this.GetHashCode());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientRequestEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentBrandEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentTypeEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EquipmentStatusEntityTypeConfiguration());
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await _mediator.DispatchDomainEventsAsync(this);

            var result = await base.SaveChangesAsync();

            return true;
        }

        public class EquipmentContextDesignFactory : IDesignTimeDbContextFactory<EquipmentContext>
        {
            public EquipmentContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<EquipmentContext>()
                    .UseSqlServer("Server=.;Initial Catalog=Microsoft.eShopOnContainers.Services.OrderingDb;Integrated Security=true");

                return new EquipmentContext(optionsBuilder.Options,new NoMediator());
            }

            class NoMediator : IMediator
            {
                public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default(CancellationToken)) where TNotification : INotification
                {
                    return Task.CompletedTask;
                }

                public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default(CancellationToken))
                {
                    return Task.FromResult<TResponse>(default(TResponse));
                }

                public Task Send(IRequest request, CancellationToken cancellationToken = default(CancellationToken))
                {
                    return Task.CompletedTask;
                }
            }
        }
    }
}