using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentBrandAggregate;
using eSupport.Services.Equipment.Domain.SeedWork;
using eSupport.Services.Equipment.Domain.Exceptions;

namespace eSupport.Services.Equipment.Infrastructure.Repositories
{
    public class EquipmentBrandRepository : IEquipmentBrandRepository
    {
        private readonly EquipmentContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public EquipmentBrandRepository(EquipmentContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public EquipmentBrand Add(EquipmentBrand equipmentBrand)
        {
            return  _context.EquipmentBrand.Add(equipmentBrand).Entity;
               
        }
        public async Task<EquipmentBrand> GetAsync(int equipmentBrand)
        {
            var equipmentsBrand = await _context.EquipmentBrand.FindAsync(equipmentBrand);
            if (equipmentsBrand != null)
            {
                await _context.Entry(equipmentsBrand)
                    .Collection(i => i.Name).LoadAsync();
            }

            return equipmentsBrand;
        }
        public void Update(EquipmentBrand equipmentBrand)
        {
            _context.Entry(equipmentBrand).State = EntityState.Modified;
        }
    }
}