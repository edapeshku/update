using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentTypeAggregate;
using eSupport.Services.Equipment.Domain.SeedWork;
using eSupport.Services.Equipment.Domain.Exceptions;

namespace eSupport.Services.Equipment.Infrastructure.Repositories
{
    public class EquipmentTypeRepository : IEquipmentTypeRepository
    {
        private readonly EquipmentContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public EquipmentTypeRepository(EquipmentContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public EquipmentType Add(EquipmentType equipmentType)
        {
            return  _context.EquipmentType.Add(equipmentType).Entity;
               
        }
        public async Task<EquipmentType> GetAsync(int equipmentType)
        {
            var equipmentsType = await _context.EquipmentType.FindAsync(equipmentType);
            if (equipmentsType != null)
            {
                await _context.Entry(equipmentsType)
                    .Collection(i => i.Name).LoadAsync();
            }

            return equipmentsType;
        }
        public void Update(EquipmentType equipmentType)
        {
            _context.Entry(equipmentType).State = EntityState.Modified;
        }
    }
}