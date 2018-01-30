using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate;
using eSupport.Services.Equipment.Domain.SeedWork;
using eSupport.Services.Equipment.Domain.Exceptions;

namespace eSupport.Services.Equipment.Infrastructure.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly EquipmentContext _context;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }
        public EquipmentRepository(EquipmentContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Equipments Add(Equipments equipments)
        {
            return  _context.Equipments.Add(equipments).Entity;
               
        }
        public async Task<Equipments> GetAsync(int equipmentsId)
        {
            var equipments = await _context.Equipments.FindAsync(equipmentsId);
            if (equipments != null)
            {
                await _context.Entry(equipments)
                    .Collection(i => i.Name).LoadAsync();
                await _context.Entry(equipments)
                    .Reference(i => i.Code).LoadAsync();
            }

            return equipments;
        }
        public void Update(Equipments equipments)
        {
            _context.Entry(equipments).State = EntityState.Modified;
        }
    }
}